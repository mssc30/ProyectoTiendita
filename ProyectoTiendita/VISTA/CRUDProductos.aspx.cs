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

    public partial class CRUDProductos : System.Web.UI.Page
    {
        protected void btnWebServer_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsumirServicioExterno.aspx", true);
        }
        protected void btnProductosCRUD_Click(object sender, EventArgs e)
        {
            Response.Redirect("Principal.aspx", true);
        }

        protected void btnUsersCRUD_Click(object sender, EventArgs e)
        {
            Response.Redirect("CRUDUsuarios.aspx", true);
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
        protected void dgvProductos_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[4].Text = Server.HtmlDecode(e.Row.Cells[4].Text);
            }
        }


        static Producto antiguo;
        String nombre, foto;
        int estado, idProd;
        double precio;

        // Objeto usado para el manejo del servicio
        ServiceReference3.ServicioProductoSoapClient servicio = new ServiceReference3.ServicioProductoSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty((String)(Session["isAdmin"])))
                llenarTabla();
            else
                Response.Redirect("LoginAdmin.aspx", true);
        }

        public void llenarTabla()
        {
            try
            {
                dgvProductos.DataSource = null;
                dgvProductos.DataBind();
            }
            catch (Exception)
            {

            }
            try
            {
                dgvProductos.DataSource = servicio.ObtenerTodos();
                dgvProductos.DataBind();
            }
            catch (Exception)
            {

            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            nombre = txtNombre.Text.ToString();
            foto = txtFoto.Text.ToString();
            estado = int.Parse(txtEstado.Text.ToString());
            precio = double.Parse(txtPrecio.Text.ToString());
            idProd = int.Parse(txtID.Text.ToString());

            ServiceReference3.Producto producto = new ServiceReference3.Producto();
            producto.idProducto = idProd;
            producto.nombre = nombre;
            producto.foto = foto;
            producto.estado = estado;
            producto.precio = precio;
            try
            {
                //LLamada al metodo modificar un producto que se encuentra en el servicio
                servicio.ModificarProducto(producto);

                limpiar();
                llenarTabla();
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                txtID.Enabled = true;
            }
            catch (Exception)
            {

            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            antiguo = new Producto();

            //LLamada al metodo obtener uno que se encuentra en el servicio
            ServiceReference3.Producto prod = servicio.ObtenerUno(int.Parse(txtID.Text.ToString()));

            if (prod!= null)
            {
                antiguo.idProducto = prod.idProducto;
                antiguo.nombre = prod.nombre;
                antiguo.precio = prod.precio;
                antiguo.estado = prod.estado;
                antiguo.foto = prod.foto;
            }

            if (antiguo != null)
            {
                txtID.Enabled = false;
                txtEstado.Text = antiguo.estado+"";
                txtFoto.Text = antiguo.foto;
                txtNombre.Text = antiguo.nombre;
                txtPrecio.Text = antiguo.precio + "";

                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
            
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            //LLamada al metodo dentro del servicio que elimina un producto 
            if (servicio.EliminarProducto(int.Parse(txtID.Text.ToString())))
            {
                llenarTabla();
                limpiar();
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                txtID.Enabled = true;
            }
        }

        public void limpiar()
        {
            txtEstado.Text = "";
            txtFoto.Text = "";
            txtID.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            nombre = txtNombre.Text.ToString();
            foto = txtFoto.Text.ToString();
            estado = int.Parse(txtEstado.Text.ToString());
            precio = double.Parse(txtPrecio.Text.ToString());

            ServiceReference3.Producto producto = new ServiceReference3.Producto();
            producto.nombre = nombre;
            producto.foto = foto;
            producto.estado = estado;
            producto.precio = precio;
            try
            {
                //LLamada al metodo agregar producto que se encuentra en el servicio
                servicio.AgregarProducto(producto);
                limpiar();
                llenarTabla();
                txtID.Enabled = true;
            }
            catch (Exception)
            {

            }
        }
    }
}