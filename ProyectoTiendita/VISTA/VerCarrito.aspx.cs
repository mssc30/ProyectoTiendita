using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using ProyectoTiendita.DATOS;
using ProyectoTiendita.POJOS;

namespace ProyectoTiendita.VISTA
{
    public partial class VerCarrito : System.Web.UI.Page
    {

        daoCliente daoCliente;
        daoCarrito daoCarrito;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty((String)(Session["usuario"])))
            {
                btnIniciarSesion.Text = "Cerrar Sesion";

                daoCarrito = new daoCarrito();
                daoCliente = new daoCliente();
                dgvPedido.DataSource = daoCarrito.obtenerTodos((String)(Session["usuario"]));
                dgvPedido.DataBind();
              

            }
            else
            {
                Response.Redirect("LoginAdmin.aspx", true);
            }
        }

        double total = 0;
        protected void dgv_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].Visible = false;
            e.Row.Cells[1].Visible = false;

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (!string.IsNullOrEmpty(e.Row.Cells[4].Text))
                    total += Convert.ToDouble(e.Row.Cells[4].Text);
            }

            Label2.Text = "Total de la compra: $"+total.ToString();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            //SI SE DESEA CANCELAR EL PEDIDO SE ELIMINA EL ARCHIVO XML DONDE SE TIENEN LOS PRODUCTOS QUE
            //SE FUERON AGREGANDO AL CARRITO
            daoCarrito.eliminarCarrito((String)(Session["usuario"]));
            Response.Redirect("Principal.aspx", true);
            
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            //ID DEL PEDIDO
            String idPedido = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            String idUsuario = (String)(Session["usuario"]);
            daoCarrito.agregarAdmin(daoCarrito.obtenerTodos(idUsuario), idPedido);
            daoCarrito.eliminarCarrito(idUsuario);
            Response.Redirect("Principal.aspx", true);

        }
        

        protected void btnPerfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("CRUDCliente.aspx", true);
        }

        protected void btnPedido_Click(object sender, EventArgs e)
        {
            Response.Redirect("Principal.aspx", true);
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
        protected void btnWebServer_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsumirServicioExterno.aspx", true);
        }
    }
}