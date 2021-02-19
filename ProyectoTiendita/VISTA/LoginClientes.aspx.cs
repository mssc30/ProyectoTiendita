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
    public partial class LoginClientes : System.Web.UI.Page
    {
        daoCliente daoCliente = new daoCliente();
        String user, contra;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            user = txtUser.Text.ToString();
            contra = txtContra.Text.ToString();

            if (daoCliente.autenticar(user, Encriptar.MD5(contra)))
            {
                //ABRIR PAGINA DE INICIO
                Session["usuario"] = user;
                Session["sesion"] = true;
                Response.Redirect("CRUDCliente.aspx", true);
            }
            else
            {
                lblError.Text = "USUARIO O CONTRASEÑA INCORRECTOS";
                lblError.Visible = true;
            }
        }
    }
}