using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using ProyectoTiendita.DATOS;

namespace ProyectoTiendita.VISTA
{
    public partial class Pedidos : System.Web.UI.Page
    {
        //String rutaPedidos = @"C:\Users\Jesus Ramirez Ayala\Desktop\pedidos.xml";
        String rutaPedidos = @"d:\pedidos.xml";

        daoPedido daopedido; 
        protected void Page_Load(object sender, EventArgs e)
        {
            daopedido = new daoPedido();
            //CARGAR LA INFORMACION DEL XML A LA TABLA
            if (File.Exists(rutaPedidos))
            {

                XDocument xmlPoliza = XDocument.Load(rutaPedidos);

                var poli = from cot in xmlPoliza.Elements("pedidos") select cot;

                int contador = 0;

                foreach (XElement pedido in poli.Elements("usuario"))
                {
                    String clave = "hola";

                    Label a = new Label();
                    a.Text = "<br/><br/>Dirección " + pedido.Element("Usuario").Value;

                    Label b = new Label();
                    a.Text += "<br/> Nombre " + pedido.Element("Nombre").Value;

                    var ele = from cot in pedido.Elements("pedido").Elements("producto") select cot;

                    foreach (XElement el in ele)
                    {
                        a.Text += "<br/>Producto " + el.Element("Cantidad").Value +
                            " " + el.Element("Nombre").Value;

                        a.Text += "<br/>Subtotal " + el.Element("Subtotal").Value;
                    }

                    a.Text += "<br/>";

                    Button maComplet = new Button();
                    maComplet.Text = "Marcar como completado " + clave;
                    maComplet.ID = clave;
                    maComplet.Click += MaComplet_Click;

                    this.Page.Form.Controls.Add(a);
                    this.Page.Form.Controls.Add(maComplet);
                }

                }
        }

        private void MaComplet_Click(object sender, EventArgs e)
        {
            //ELIMINAR DEL XML E INGRESARLO A LA BD
           // Response.Write(@"<script language =’javascript’> alert(‘Funciona’);</ script >" + sender.ToString());
        }
    }
}