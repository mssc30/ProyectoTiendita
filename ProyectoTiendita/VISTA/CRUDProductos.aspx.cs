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
        daoProducto daoProducto = new daoProducto();
        List<Producto> productos = new List<Producto>();
        Producto producto;
        static Producto antiguo;
        String nombre, foto;
        int estado, idProd;
        double precio;
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }

        public void llenarTabla()
        {
            try
            {
                productos = daoProducto.obtenerTodos();
                dgvProductos.DataSource = productos;
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

            producto = new Producto(idProd, nombre, precio, estado, foto);

            try
            {
                daoProducto.modificarProducto(producto);
                limpiar();
                llenarTabla();
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
            catch (Exception)
            {

            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            antiguo = daoProducto.obtenerUno(int.Parse(txtID.Text.ToString()));

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
            if (daoProducto.eliminarProducto(int.Parse(txtID.Text.ToString())))
            {
                llenarTabla();
                limpiar();
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
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

            producto = new Producto(nombre, precio, estado, foto);

            try
            {
                daoProducto.agregar(producto);
                limpiar();
                llenarTabla();
            }
            catch (Exception)
            {

            }
        }
    }
}