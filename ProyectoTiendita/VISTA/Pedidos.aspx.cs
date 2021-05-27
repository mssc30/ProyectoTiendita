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
        protected void btnWebServer_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsumirServicioExterno.aspx", true);
        }
        protected void btnProductosCRUD_Click(object sender, EventArgs e)
        {
            Response.Redirect("CRUDProductos.aspx", true);
        }

        protected void btnUsersCRUD_Click(object sender, EventArgs e)
        {
            Response.Redirect("CRUDUsuarios.aspx", true);
        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Session["usuario"] = null;
            Session["isAdmin"] = null;
            Session["sesion"] = null;
            Response.Redirect("LoginAdmin.aspx", true);
        }

        protected void btnVerPedidos_Click(object sender, EventArgs e)
        {
            Response.Redirect("Principal.aspx", true);
        }



        //METODO PARA LLENAR LA TABLA
        public void obtenerPedidos()
        {
            List<pedidoAdmin> pedidos = new List<pedidoAdmin>();

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
            column.ColumnName = "DIRECCION";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "PEDIDO";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Double");
            column.ColumnName = "TOTAL";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ESTADO";
            table.Columns.Add(column);

            dgvPedidos.Columns.Clear();
            pedidos = new daoCarrito().obtenerTodosAdmin("PENDIENTE");

            // Create new DataRow objects and add to DataTable.
            foreach (pedidoAdmin p in pedidos)
            {
                row = table.NewRow();
                row["ID"] = p.ID;
                row["USUARIO"] = new daoCliente().obtenerUno(p.ID_CLIENTE).nombre;
                row["DIRECCION"] = p.DIRECCION;
                row["PEDIDO"] = p.PEDIDO;
                row["TOTAL"] = p.TOTAL;
                row["ESTADO"] = p.ESTADO;
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
            if (!String.IsNullOrEmpty((String)(Session["isAdmin"])))
            {
                obtenerPedidos();
                entregadosTabla();
            }
            else
                Response.Redirect("LoginAdmin.aspx", true);
        }

        protected void dgvPedidos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //OBTENER LA CLAVE A BUSCAR
            String claveBuscar = dgvPedidos.Rows[Int32.Parse(e.CommandArgument.ToString())].Cells[1].Text;

            new daoCarrito().eliminarPendiente(claveBuscar);
            obtenerPedidos();
            entregadosTabla();
        }

        public void entregadosTabla()
        {
            try
            {
                dgvEntregados.DataSource = null;
                dgvEntregados.DataBind();
            }
            catch (Exception)
            {

            }

            dgvEntregados.DataSource = new daoCarrito().obtenerTodosAdmin("ENTREGADO");
            dgvEntregados.DataBind();
        }
    }
}