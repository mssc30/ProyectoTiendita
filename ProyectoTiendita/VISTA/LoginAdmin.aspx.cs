using ProyectoTiendita.DATOS;
using ProyectoTiendita.POJOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoTiendita.VISTA
{
    public partial class LoginAdmin : System.Web.UI.Page
    {
        protected void btnWebServer_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsumirServicioExterno.aspx", true);
        }
        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            
                Response.Redirect("Principal.aspx", true);
            
        }

        String user, contra;
        daoUsuario daoUsuario = new daoUsuario();
        daoCliente daoCliente = new daoCliente();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Response.Redirect("CRUDCliente.aspx", true);
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            user = txtUser.Text.ToString();
            contra = Encriptar.MD5(txtContra.Text.ToString());

            if (chkAdmin.Checked)
            {
                if (daoUsuario.autenticar(user, contra))
                {
                    //ABRIR PAGINA DE INICIO
                    Session["usuario"] = user;
                    Session["isAdmin"] = "cierto";
                    Session["sesion"] = "cierto";
                    Response.Redirect("Principal.aspx", true);
                }
                else
                {
                    lblError.Visible = true;
                }
            }
            else
            {
                if (daoCliente.autenticar(user, contra))
                {
                    //ABRIR PAGINA DE INICIO
                    Session["sesion"] = "cierto";
                    Session["usuario"] = user;
                    Response.Redirect("Principal.aspx", true);
                }
                else
                {
                    lblError.Visible = true;
                }
            }
        }
    }
}