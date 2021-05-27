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
using System.Windows.Media.Imaging;
using System.Net;

namespace ProyectoTiendita.VISTA
{
    public partial class Principal : System.Web.UI.Page
    {
        String userActual, isAdmin;
        daoProducto daoProducto;
        daoUsuario daoUsuario;
        daoCarrito daoCarrito;
        List<Producto> listaProd;
        
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
            //
            daoCarrito = new daoCarrito();
            listaProd = new List<Producto>();
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

            //CICLO USADO PARA COLOCAR LOS BOTONES DENTRO DE LA TABLA PRODUCTOS
            foreach (DataColumn dc in table.Columns)
            {
                ButtonField bf = new ButtonField();
                bf.CommandName = dc.ColumnName+"";
                bf.DataTextField = dc.ColumnName;
                dgvProductos.Columns.Add(bf);
                break;
            }


            foreach (DataColumn dc in table.Columns)
            {
                ButtonField bf = new ButtonField();
                bf.CommandName = dc.ColumnName + "";
                bf.DataTextField = dc.ColumnName;
                bf.ImageUrl = "https://i.ibb.co/Gn2ZQPs/15649512571605802262-32.png";
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
                dgvProductos.Columns[1].Visible = true;
            }
        }



        //ESTE METODO SE DESENCADENA CUANDO SE LE DA CLIC AL BOTON QUE ESTA DENTRO DE LA TABLA
        //PRODUCTOS
        protected void dgvProductos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //SE OBTIENE INFORMACION DEL PRODUCTO QUE SE AGREGO AL CARRITO
            int IdProd = listaProd[Int32.Parse(e.CommandArgument + "")].idProducto;
            double precio = listaProd[Int32.Parse(e.CommandArgument + "")].precio;
            daoCarrito.agregar(IdProd, precio, (String)(Session["usuario"]));
            
        }

        protected void dgvProductos_RowDataBound(object sender, GridViewRowEventArgs e)
        { 

            if (String.IsNullOrEmpty((String)(Session["sesion"])) || !String.IsNullOrEmpty((String)(Session["isAdmin"])))
            {
                //no hay sesion iniciada
                e.Row.Cells[1].Visible = false;
            }
            else
            {
                e.Row.Cells[1].Visible = true;
            }
                       
            e.Row.Cells[0].Visible = false;

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[4].Text = Server.HtmlDecode(e.Row.Cells[4].Text);
            }
        }

        protected void btnPedido_Click(object sender, EventArgs e)
        {
            Response.Redirect("VerCarrito.aspx",true);
        }

        protected void btnWebServer_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsumirServicioExterno.aspx", true);
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
                Response.Redirect("LoginAdmin.aspx", true);
            }
        }

      
    }
}