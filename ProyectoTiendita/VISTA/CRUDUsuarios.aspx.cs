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
    public partial class CRUDUsuarios : System.Web.UI.Page
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
            Response.Redirect("Principal.aspx", true);
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
            Response.Redirect("Pedidos.aspx", true);
        }


        String usuario, contrasenia, nombre, apellidos, telefono;
        //Usuario user;
        ServiceReference5.Usuario user;
        //static Usuario antiguo;
        static ServiceReference5.Usuario antiguo;
        //daoUsuario daoUser = new daoUsuario();
        //List<Usuario> usuarios;
        ServiceReference5.ServicioUsuarioSoapClient servicio = new ServiceReference5.ServicioUsuarioSoapClient();

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            //antiguo = daoUser.obtenerUno(txtUsuario.Text.ToString());
            antiguo = servicio.ObtenerUno(txtUsuario.Text.ToString());

            if (antiguo != null){
                txtUsuario.Text = antiguo.usuario;
                txtTelefono.Text = antiguo.telefono;
                txtNombre.Text = antiguo.nombre;
                txtContrasena.Text = antiguo.contrasena;
                txtApellidos.Text = antiguo.apellidos;

                btnEliminar.Enabled = true;
                btnActualizar.Enabled = true;
            }

            
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            usuario = txtUsuario.Text.ToString();

            if (!antiguo.contrasena.Equals(txtContrasena.Text.ToString()))
            {
                contrasenia = Encriptar.MD5(txtContrasena.Text.ToString());
            }
            else
            {
                contrasenia = txtContrasena.Text.ToString();
            }
                        
            nombre = txtNombre.Text.ToString();
            apellidos = txtApellidos.Text.ToString();
            telefono = txtTelefono.Text.ToString();

            //user = new Usuario(usuario, contrasenia, nombre, apellidos, telefono);
            user = new ServiceReference5.Usuario();
            user.usuario = usuario;
            user.contrasena = contrasenia;
            user.nombre = nombre;
            user.apellidos = apellidos;
            user.telefono = telefono;

            try{
                //daoUser.modificarUsuario(user);
                servicio.ModificarUsuario(user);
            
                llenarTabla();
                limpiarCampos();

                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            catch (Exception )
            {
               
            }

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            //daoUser.eliminarUsuario(txtUsuario.Text.ToString())
            if (servicio.EliminarUsuario(txtUsuario.Text.ToString()))
            {
                llenarTabla();
                limpiarCampos();

                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        public void llenarTabla()
        {
            try
            {
                try
                {
                    dgvUsuarios.DataSource = null;
                    dgvUsuarios.DataBind();
                }
                catch (Exception)
                {

                }
                //usuarios = daoUser.obtenerTodos();
                dgvUsuarios.DataSource = servicio.ObtenerTodos();
                dgvUsuarios.DataBind();
            }
            catch (Exception)
            {

            }
        }

        public void limpiarCampos()
        {
            txtApellidos.Text = "";
            txtContrasena.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtUsuario.Text = "";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty((String)(Session["isAdmin"])))
                llenarTabla();
            else
                Response.Redirect("LoginAdmin.aspx", true);
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            usuario = txtUsuario.Text.ToString();
            contrasenia = Encriptar.MD5(txtContrasena.Text.ToString());
            nombre = txtNombre.Text.ToString();
            apellidos = txtApellidos.Text.ToString();
            telefono = txtTelefono.Text.ToString();

            //user = new Usuario(usuario, contrasenia, nombre, apellidos, telefono);
            user = new ServiceReference5.Usuario();
            user.usuario = usuario;
            user.contrasena = contrasenia;
            user.nombre = nombre;
            user.apellidos = apellidos;
            user.telefono = telefono;

            try
            {
                //daoUser.agregar(user);
                servicio.AgregarUsuario(user);
            
                llenarTabla();
                limpiarCampos();
            }
            catch (Exception )
            {

            }
        }
    }
}