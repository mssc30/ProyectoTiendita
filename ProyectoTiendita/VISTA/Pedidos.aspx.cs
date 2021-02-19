using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoTiendita.DATOS;

namespace ProyectoTiendita.VISTA
{
    public partial class Pedidos : System.Web.UI.Page
    {

        int index_seleccionado = -1;
        daoPedido daopedido; 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (index_seleccionado == -1)
            {
                btnModificar.Enabled = false;
            }
            daopedido = new daoPedido();
            //CARGAR LA INFORMACION DE LA BASE DE DATOS A LA TABLA
            dgvPedidos.DataSource = daopedido.obtenerTodos();
            dgvPedidos.DataBind();
        }


        protected void dgvPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            index_seleccionado = dgvPedidos.SelectedRow.RowIndex;
            if (index_seleccionado == -1)
            {
                btnModificar.Enabled = false;
            }
            else
            {
                btnModificar.Enabled = true;
            }

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (index_seleccionado != -1)
            {
                //MODIFICAR EL ESTADO DEL PEDIDO
                daopedido.modificarPedido(daopedido.obtenerTodos()[index_seleccionado]);
            }
            index_seleccionado = -1;
        }
    }
}