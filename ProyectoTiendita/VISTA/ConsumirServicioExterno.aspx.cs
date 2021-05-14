using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoTiendita.VISTA
{
    public partial class ConsumirServicioExterno : System.Web.UI.Page
    {
        String userActual, isAdmin;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty((String)(Session["usuario"])))
            {

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

            }
            else
            {
                btnPerfil.Visible = false;
                btnPedido.Visible = false;
                btnVerPedidos.Visible = false;
                btnProductosCRUD.Visible = false;
                btnUsersCRUD.Visible = false;
            }
        }


        protected void btnConsultar_Click1(object sender, EventArgs e)
        {
            String codigo = DropDownList1.SelectedValue;
            String fechaInicial = DateTime.Parse(txtFecha1.Text).ToString("dd/MM/yyyy");
            String fechaFinal = DateTime.Parse(txtFecha2.Text).ToString("dd/MM/yyyy");

            ServiceReference2.wsindicadoreseconomicosSoapClient WB = new ServiceReference2.wsindicadoreseconomicosSoapClient();
            DataSet a = WB.ObtenerIndicadoresEconomicos(codigo, fechaInicial, fechaFinal, "Socorro", "N", "kokodiangelo@gmail.com", "MONS51OGIA");
            dgvDatosServer.DataSource = a;
            dgvDatosServer.DataBind();
        }

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

        protected void btnPedido_Click(object sender, EventArgs e)
        {
            Response.Redirect("VerCarrito.aspx", true);
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
            Response.Redirect("Principal.aspx", true);
        }
    }
}