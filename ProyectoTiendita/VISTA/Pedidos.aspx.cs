using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using ProyectoTiendita.DATOS;
using ProyectoTiendita.POJOS;

namespace ProyectoTiendita.VISTA
{
    public partial class Pedidos : System.Web.UI.Page
    {
        //String rutaPedidos = @"C:\Users\Jesus Ramirez Ayala\Desktop\pedidos.xml";
        String rutaPedidos = @"d:\pedidos.xml";
        

        //METODO PARA LLENAR LA TABLA
        public void obtenerPedidos()
        {
            String pedidoo;
            List<PedidoAux> pedidos = new List<PedidoAux>();

            //CARGAR LA INFORMACION DEL XML A LA TABLA
            if (File.Exists(rutaPedidos))
            {
                //CARGAR XML A UN XDOCUMENT
                XDocument xmlPedidos = XDocument.Load(rutaPedidos);
                var poli = from cot in xmlPedidos.Elements("pedidos") select cot;

                //RECORRER POR ELEMENTO USUARIO
                foreach (XElement pedido in poli.Elements("usuario"))
                {
                    //SI ESE USUARIO CUENTA CON UN PEDIDO ACTIVO
                    if (pedido.Element("pedido") != null) {
                        
                        //OBTIENE LOS VALORES DEL NODO
                        String clave = pedido.Element("pedido").Element("IdPedido").Value;
                        Double total = 0;
                        String user = pedido.Element("Nombre").Value + ".";
                        pedidoo = "";

                        //RECORRE EL PEDIDO POR ELEMENTOS PRODUCTO
                        var ele = from cot in pedido.Element("pedido").Elements("producto") select cot;
                        foreach (XElement el in ele)
                        {
                            pedidoo += "\n" + el.Element("Cantidad").Value + " || " +
                                " " + el.Element("Nombre").Value + " <> ";
                            total += Double.Parse(el.Element("Subtotal").Value);
                        }

                        //AÑADE EL PEDIDO A LA LISTA
                        pedidos.Add(new PedidoAux(clave, pedidoo, total, user));
                    }
                }

            }

            // Create new DataTable and DataSource objects.
            DataTable table = new DataTable();

            // Declare DataColumn and DataRow variables.
            DataColumn column;
            DataRow row;
            DataView view;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ID";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "USUARIO";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "PEDIDO";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Double");
            column.ColumnName = "TOTAL";
            table.Columns.Add(column);

            dgvPedidos.Columns.Clear();

            // Create new DataRow objects and add to DataTable.
            foreach (PedidoAux p in pedidos)
            {
                row = table.NewRow();
                row["ID"] = p.id;
                row["USUARIO"] = p.usuario;
                row["PEDIDO"] = p.descripcion;
                row["TOTAL"] = p.total;
                table.Rows.Add(row);
            }

            // Create a DataView using the DataTable.
            view = new DataView(table);
            // Set a DataGrid control's DataSource to the DataView.
            dgvPedidos.DataSource = view;

            //CICLO USADO PARA COLOCAR LOS BOTONES DENTRO DE LA TABLA PRODUCTOS
            foreach (DataColumn dc in table.Columns)
            {
                ButtonField bf = new ButtonField();
                bf.CommandName = dc.ColumnName.ToString();
                bf.DataTextField = dc.ColumnName;
                bf.ButtonType = ButtonType.Image;
                bf.ImageUrl = "https://i.ibb.co/372MhgM/11875166141558096434-32.png";
                dgvPedidos.Columns.Add(bf);
                break;
            }

            dgvPedidos.DataBind();
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            obtenerPedidos();   
            
        }

        protected void dgvPedidos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //ELIMINAR DEL XML E INGRESARLO A LA BD
            XmlDocument xmlPedidos =new  XmlDocument();
            xmlPedidos.Load(rutaPedidos);

            //OBTENER LA CLAVE A BUSCAR
            String claveBuscar = dgvPedidos.Rows[Int32.Parse(e.CommandArgument + "")].Cells[1].Text;

            //BUSCAR EL NODO CON LA CLAVE DETERMINADA
            foreach (XmlNode node in xmlPedidos.DocumentElement.ChildNodes)
            {
                String id = node.ChildNodes[2].ChildNodes[0].InnerText;

                //SI ENCUENTRA LA CLAVE
                if (id.Equals(claveBuscar))
                {
                    //AGREGAR PEDIDO AL ARCHIVO DE LA BASE DE DATOS
                    new daoPedido().agregar(new Pedido(node.ChildNodes[0].InnerText, 
                        Double.Parse(dgvPedidos.Rows[Int32.Parse(e.CommandArgument + "")].Cells[4].Text), 
                        claveBuscar));

                    //ELIMINAR EL NODO DEL ARCHIVO XML
                    node.RemoveChild(node.ChildNodes[2]);
                    xmlPedidos.Save(rutaPedidos);
                    break;
                }
            }

            obtenerPedidos();
        }
    }
}