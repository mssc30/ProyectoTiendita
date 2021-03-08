using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using ProyectoTiendita.DATOS;
using ProyectoTiendita.POJOS;

namespace ProyectoTiendita.VISTA
{
    public partial class VerCarrito : System.Web.UI.Page
    {
        String rutaAux = @"C:\Users\Jesus Ramirez Ayala\Desktop\productos.xml";
        String rutaPedidos = @"C:\Users\Jesus Ramirez Ayala\Desktop\pedidos.xml";
        daoCliente daoCliente;
        protected void Page_Load(object sender, EventArgs e)
        {
            daoCliente = new daoCliente();
            if (File.Exists(rutaAux))
            {
                XDocument document = XDocument.Load(rutaAux);
                var result = from elemento in document.Descendants("producto")
                             select new
                             {

                                 IdProducto = elemento.Element("IdProducto").Value,
                                 Nombre = elemento.Element("Nombre").Value,
                                 Cantidad = elemento.Element("Cantidad").Value,
                                 Subtotal = elemento.Element("Subtotal").Value
                             };
                dgvPedido.DataSource = result;
                dgvPedido.DataBind();
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            File.Delete(rutaAux);
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!File.Exists(rutaPedidos))
            {
                String idUsuario = (String)(Session["usuario"]);
                Cliente user = daoCliente.obtenerUno(idUsuario);
                XDocument documentoP = XDocument.Load(rutaAux);
                XDocument document = new XDocument(new XDeclaration("1.0", "utf-8", null));
                XElement nodoRaiz = new XElement("pedidos");
                document.Add(nodoRaiz);
                XElement nodo = new XElement("usuario");
                nodo.Add(new XElement("Usuario", user.direccion));
                nodo.Add(new XElement("Nombre", user.nombre));
                nodoRaiz.Add(nodo);
                XElement pedido = new XElement("pedido");
                nodo.Add(pedido);
                foreach (XElement x in documentoP.Descendants("producto"))
                {
                    pedido.Add(x);
                }
                document.Save(rutaPedidos);
                File.Delete(rutaAux);
            }
            
        }
    }
}