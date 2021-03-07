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

namespace ProyectoTiendita.VISTA
{
    public partial class Principal : System.Web.UI.Page
    {
        String userActual, isAdmin, sesion;
        daoProducto daoProducto;

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
            daoProducto = new daoProducto();

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

            
            column = new DataColumn();
            column.DataType = Type.GetType("System.Boolean");
            column.ColumnName = "AGREGAR AL CARRITO";
            table.Columns.Add(column);


            dgvProductos.Columns.Clear();


            // Create new DataRow objects and add to DataTable.
            foreach (Producto p in daoProducto.obtenerTodos())
            {
                row = table.NewRow();
                row["NOMBRE"] = p.nombre;
                row["PRECIO"] = p.precio;
                row["IMAGEN"] = p.foto;
                row["AGREGAR AL CARRITO"]= true;
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
            }
        }

        protected void dgvProductos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Label1.Text = "Ente:D" + e.CommandArgument;
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

        public void onClick()
        {
            
        }
    }
}