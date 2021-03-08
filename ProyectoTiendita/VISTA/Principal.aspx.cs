using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoTiendita.DATOS;
using ProyectoTiendita.POJOS;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Xml.Linq;
using System.Xml;

namespace ProyectoTiendita.VISTA
{
    public partial class Principal : System.Web.UI.Page
    {
        String userActual, isAdmin, sesion;
        daoProducto daoProducto;
        daoUsuario daoUsuario;
        List<Producto> listaProd;
        String ruta = @"C:\Users\Jesus Ramirez Ayala\Desktop\productos.xml";
        protected void btnProductosCRUD_Click(object sender, EventArgs e)
        {
            Response.Redirect("CRUDProductos.aspx", true);
        }

        protected void btnUsersCRUD_Click(object sender, EventArgs e)
        {
            Response.Redirect("CRUDUsuarios.aspx", true);
        }

        protected void btnPerfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("CRUDCliente.aspx", true);
        }

        protected void btnVerPedidos_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pedidos.aspx", true);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            listaProd= new List<Producto>();
            daoProducto = new daoProducto();
            daoUsuario = new daoUsuario();
            // Create new DataTable and DataSource objects.
            DataTable table = new DataTable();

            // Declare DataColumn and DataRow variables.
            DataColumn column;
            DataRow row;
            DataView view;
            
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "NOMBRE";
            table.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.Double");
            column.ColumnName = "PRECIO";
            table.Columns.Add(column);


            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "IMAGEN";
            table.Columns.Add(column);


            dgvProductos.Columns.Clear();
            listaProd = daoProducto.obtenerTodos();

            // Create new DataRow objects and add to DataTable.
            foreach (Producto p in listaProd)
            {
                row = table.NewRow();
                row["NOMBRE"] = p.nombre;
                row["PRECIO"] = p.precio;
                row["IMAGEN"] = p.foto;
                table.Rows.Add(row);


            }

            // Create a DataView using the DataTable.
            view = new DataView(table);
            // Set a DataGrid control's DataSource to the DataView.
            dgvProductos.DataSource = view;

            foreach (DataColumn dc in table.Columns)
            {
                ButtonField bf = new ButtonField();
                bf.CommandName = dc.ColumnName+"";
                bf.DataTextField = dc.ColumnName;
                bf.ImageUrl = "https://cdn.icon-icons.com/icons2/259/PNG/128/ic_add_shopping_cart_128_28122.png";
                bf.ButtonType = ButtonType.Image;
                dgvProductos.Columns.Add(bf);
                break;
            }

            dgvProductos.DataBind();


            if (!String.IsNullOrEmpty((String)(Session["usuario"]))) { 

                userActual = (String)(Session["usuario"]);
                btnIniciarSesion.Text = "Cerrar Sesion";

                if (!String.IsNullOrEmpty((String)(Session["isAdmin"])))
                {
                    isAdmin = (String)(Session["isAdmin"]);
                    btnPerfil.Visible = false;
                    btnPedido.Visible = false;
                }
                else
                {
                    btnVerPedidos.Visible = false;
                    btnProductosCRUD.Visible = false;
                    btnUsersCRUD.Visible = false;
                }

            }else { 
                btnPerfil.Visible = false;
                btnPedido.Visible = false;
                btnVerPedidos.Visible = false;
                btnProductosCRUD.Visible = false;
                btnUsersCRUD.Visible = false;
                dgvProductos.Columns[0].Visible = false;
            }
        }

        protected void dgvProductos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Label1.Text = "Ente:D" + e.CommandArgument;
            int IdProd = listaProd[Int32.Parse(e.CommandArgument + "")].idProducto;
            String nombreProd= listaProd[Int32.Parse(e.CommandArgument + "")].nombre;
            double precio = listaProd[Int32.Parse(e.CommandArgument + "")].precio;
            if (!File.Exists(ruta))
            {
                XDocument document = new XDocument(new XDeclaration("1.0", "utf-8", null));
                XElement nodoRaiz = new XElement("productos");
                document.Add(nodoRaiz);
                XElement nodo = new XElement("producto");
                nodo.Add(new XElement("IdProducto", IdProd));
                nodo.Add(new XElement("Nombre", nombreProd));
                nodo.Add(new XElement("Cantidad", 1));
                nodo.Add(new XElement("Subtotal", precio));
                nodoRaiz.Add(nodo);
                document.Save(ruta);
            }
            else
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(ruta);

                XmlNode node;
                node = doc.DocumentElement;
                bool existe = false;
                foreach (XmlNode node1 in node.ChildNodes)
                {
                    if (node1.ChildNodes[0].InnerText.Equals(IdProd+""))
                    {
                        existe = true;
                        node1.ChildNodes[2].InnerText = (Int32.Parse(node1.ChildNodes[2].InnerText)+1)+"";
                        node1.ChildNodes[3].InnerText = (Double.Parse(node1.ChildNodes[2].InnerText)*precio) + "";
                        doc.Save(ruta);
                        break;
                    }
                }
                if (!existe)
                {
                    XDocument document = XDocument.Load(ruta);
                    XElement nodo = new XElement("producto");
                    nodo.Add(new XElement("IdProducto", IdProd));
                    nodo.Add(new XElement("Nombre", nombreProd));
                    nodo.Add(new XElement("Cantidad", 1));
                    nodo.Add(new XElement("Subtotal", precio));
                    document.Root.Add(nodo);
                    document.Save(ruta);
                }
            }
        }

        protected void btnPedido_Click(object sender, EventArgs e)
        {
         
            Response.Redirect("VerCarrito.aspx",true);
        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty((String)(Session["sesion"])))
            {
                Response.Redirect("LoginAdmin.aspx", true);
            }
            else
            {
                Session["usuario"] = null;
                Session["isAdmin"] = null;
                Session["sesion"] = null;
            }
        }
    }
}