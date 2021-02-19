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
        String usuario, contrasenia, nombre, apellidos, telefono;
        Usuario user;
        static Usuario antiguo;
        daoUsuario daoUser = new daoUsuario();
        List<Usuario> usuarios;

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            antiguo = daoUser.obtenerUno(txtUsuario.Text.ToString());

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

            user = new Usuario(usuario, contrasenia, nombre, apellidos, telefono);

            try{
                daoUser.modificarUsuario(user);
            
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
            if (daoUser.eliminarUsuario(txtContrasena.Text.ToString()))
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
                usuarios = daoUser.obtenerTodos();
                dgvUsuarios.DataSource = usuarios;
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
            llenarTabla();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            usuario = txtUsuario.Text.ToString();
            contrasenia = Encriptar.MD5(txtContrasena.Text.ToString());
            nombre = txtNombre.Text.ToString();
            apellidos = txtApellidos.Text.ToString();
            telefono = txtTelefono.Text.ToString();

            user = new Usuario(usuario, contrasenia, nombre, apellidos, telefono);

            try{
                daoUser.agregar(user);
            
                llenarTabla();
                limpiarCampos();
            }
            catch (Exception )
            {

            }
        }
    }
}