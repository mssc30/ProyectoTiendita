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

    public partial class CRUDCliente : System.Web.UI.Page
    {
        daoCliente daoCliente = new daoCliente();
        Cliente cliente;
        static Cliente viejosDatos;
        String nombre, apellidos, direccion, telefono, email, contrasena;

        //CUANDO HAYA SESION INICIADA
        Boolean sesion;
        String userActual; //CAMBIAR DESPUES 

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                daoCliente.eliminarCliente(userActual);
                //CERRAR SESION, MANDAR A PAGINA DE INICIO
            }
            catch (Exception)
            {

            }
        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //LLAMAR A LOG IN
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            sesion = (Boolean)(Session["sesion"]);
            userActual = (String)(Session["usuario"]);

            if (!Page.IsPostBack) {
            //si la sesion esta iniciada
                if (sesion)
                    {
                        btnRegistrar.Visible = false;
                        btnIniciarSesion.Visible = false;
                        txtEmail.Enabled = false;
                        cargarDatos();
                    }
                    else
                    {
                        btnEliminar.Visible = false;
                        btnActualizar.Visible = false;
                    }
                }
        }

        public void cargarDatos()
        {
            viejosDatos = daoCliente.obtenerUno(userActual);

            if(viejosDatos != null){
                txtApellidos.Text = viejosDatos.apellidos;
                txtContrasena.Text = viejosDatos.contrasena;
                txtDireccion.Text = viejosDatos.direccion;
                txtEmail.Text = viejosDatos.email;
                txtNombre.Text = viejosDatos.nombre;
                txtTelefono.Text = viejosDatos.telefono;
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            nombre = txtNombre.Text.ToString();
            apellidos = txtApellidos.Text.ToString();
            direccion = txtDireccion.Text.ToString();
            telefono = txtTelefono.Text.ToString();
            email = txtEmail.Text.ToString();

            if (!viejosDatos.contrasena.Equals(txtContrasena.Text.ToString()))
            {
                contrasena = Encriptar.MD5(txtContrasena.Text.ToString());
            }
            else
            {
                contrasena = viejosDatos.contrasena;
            }

            cliente = new Cliente(nombre, apellidos, direccion, telefono, email, contrasena);

                daoCliente.modificarCliente(cliente);
                //cargarDatos();
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            nombre = txtNombre.Text.ToString();
            apellidos = txtApellidos.Text.ToString();
            direccion = txtDireccion.Text.ToString();
            telefono = txtTelefono.Text.ToString();
            email = txtEmail.Text.ToString();
            contrasena = Encriptar.MD5(txtContrasena.Text.ToString());

            cliente = new Cliente(nombre, apellidos, direccion, telefono, email, contrasena);

            try
            {
                daoCliente.agregar(cliente);
                //LLAMAR A LOG IN
            }catch(Exception )
            {

            }
        }
    }
}