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
        String user, contra;
        daoUsuario daoUsuario = new daoUsuario();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            user = txtUser.Text.ToString();
            contra = Encriptar.MD5(txtContra.Text.ToString());



            if (daoUsuario.autenticar(user, Encriptar.MD5(contra)))
            {
                //ABRIR PAGINA DE INICIO
                Session["admin"] = user;
                Session["isAdmin"] = true;
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