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
        protected void Page_Load(object sender, EventArgs e)
        {

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
    }
}