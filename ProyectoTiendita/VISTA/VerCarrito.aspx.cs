using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using ProyectoTiendita.DATOS;
using ProyectoTiendita.POJOS;

namespace ProyectoTiendita.VISTA
{
    public partial class VerCarrito : System.Web.UI.Page
    {
        //RUTA DE LOS ARCHIVOS XML 
        String rutaAux;
        //String rutaPedidos = @"C:\Users\Jesus Ramirez Ayala\Desktop\pedidos.xml";
        String rutaPedidos = @"d:\pedidos.xml";
        daoCliente daoCliente;
        protected void Page_Load(object sender, EventArgs e)
        {
            //rutaAux = @"C:\Users\Jesus Ramirez Ayala\Desktop\Carrito" + ((String)Session["usuario"]) + ".xml";
            rutaAux = @"d:\Carrito" + ((String)Session["usuario"]) + ".xml";
            daoCliente = new daoCliente();
        //SE VERIFICA SI EL ARCHIVO XML DE PRODUCTOS EXISTE
            if (File.Exists(rutaAux))
            {
        //SE CARGAN LOS PRODUCTOS QUE FUERON AGREGADOS AL CARRITO DENTRO DE LA TABLA
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
            //SI SE DESEA CANCELAR EL PEDIDO SE ELIMINA EL ARCHIVO XML DONDE SE TIENEN LOS PRODUCTOS QUE
            //SE FUERON AGREGANDO AL CARRITO
            if (File.Exists(rutaAux))
            {
                File.Delete(rutaAux);
                Response.Redirect("VerCarrito.aspx", true);
            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            //SOLO SE PUEDE CONFIRMAR PEDIDO SE EXISTEN PRODUCTOS QUE REGISTRAR
            if (File.Exists(rutaAux))
            {
                //ID DEL PEDIDO
                String idPedido = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                String idUsuario = (String)(Session["usuario"]);
                //SE CARGA EL DOCUMENTO DE LOS PRODUCTOS
                XDocument documentoP = XDocument.Load(rutaAux);
                //SE OBTIENEN LOS DATOS DEL CLIENTE QUE ESTA CONFIRMANDO UN PEDIDO
                Cliente user = daoCliente.obtenerUno(idUsuario);
                //SE VERIFICA SI EXISTE EL ARCHIVO DE PEDIDOS SI NO ES ASI SE CREA
                if (!File.Exists(rutaPedidos))
                {
                    //SE CREA POR PRIMERA VES EL ARCHIVO DE PEDIDOS CON SU NODO RAIZ
                    XDocument document = new XDocument(new XDeclaration("1.0", "utf-8", null));
                    XElement nodoRaiz = new XElement("pedidos");
                    document.Add(nodoRaiz);
                    XElement nodo = new XElement("usuario");
                    nodo.Add(new XElement("Usuario", user.email));
                    nodo.Add(new XElement("Nombre", user.nombre));
                    nodoRaiz.Add(nodo);
                    XElement pedido = new XElement("pedido");
                    pedido.Add(new XElement("IdPedido", idPedido));
                    nodo.Add(pedido);
                    //CICLO PARA AGREGAR TODOS LOS PRODUCTOS AL PEDIDO
                    foreach (XElement x in documentoP.Descendants("producto"))
                    {
                        pedido.Add(x);
                    }
                    document.Save(rutaPedidos);
                }
                else
                {
                    //SI EXISTE EL DOCUMENTO DE PEDIDOS SE VERIFICA SI YA ESTA REGISTRADO EL USUARIO QUE VA
                    // A REALIZAR EL PEDIDO PARA EVITAR QUE SE REPITA
                    XmlDocument doc = new XmlDocument();
                    doc.Load(rutaPedidos);
                    XmlDocument docProd = new XmlDocument();
                    docProd.Load(rutaAux);
                    XmlNode nodoP = docProd.DocumentElement;
                    XmlNode node;
                    node = doc.DocumentElement;
                    bool existe = false;
                    foreach (XmlNode node1 in node.ChildNodes)
                    {
                        if (node1.ChildNodes[0].InnerText.Equals(idUsuario + ""))
                        {
                            existe = true;
                            XmlElement pedido = doc.CreateElement("pedido");
                            node1.AppendChild(pedido);
                            XmlElement idPed = doc.CreateElement("IdPedido");
                            idPed.InnerText = idPedido;
                            pedido.AppendChild(idPed);
                            //CICLO PARA AGREGAR TODOS LOS PRODUCTOS AL PEDIDO
                            foreach (XmlNode producto in nodoP.ChildNodes)
                            {
                                XmlElement p = doc.CreateElement("producto");
                                pedido.AppendChild(p);
                                XmlElement idProd = doc.CreateElement("IdProducto");
                                idProd.InnerText = producto.ChildNodes[0].InnerText;
                                XmlElement nombre = doc.CreateElement("Nombre");
                                nombre.InnerText = producto.ChildNodes[1].InnerText;
                                XmlElement Cantidad = doc.CreateElement("Cantidad");
                                Cantidad.InnerText = producto.ChildNodes[2].InnerText;
                                XmlElement Subtotal = doc.CreateElement("Subtotal");
                                Subtotal.InnerText = producto.ChildNodes[3].InnerText;
                                p.AppendChild(idProd);
                                p.AppendChild(nombre);
                                p.AppendChild(Cantidad);
                                p.AppendChild(Subtotal);
                            }
                            doc.Save(rutaPedidos);
                            break;
                        }
                    }
                    //SI NO EXISTE EL USUARIO SE CREA Y SE AÑADE SU PEDIDO
                    if (!existe)
                    {
                        XDocument document = XDocument.Load(rutaPedidos);
                        XElement nodo = new XElement("usuario");
                        nodo.Add(new XElement("Usuario", user.email));
                        nodo.Add(new XElement("Nombre", user.nombre));
                        document.Root.Add(nodo);
                        XElement pedido = new XElement("pedido");
                        pedido.Add(new XElement("IdPedido", idPedido));
                        nodo.Add(pedido);
                        //CICLO PARA AGREGAR TODOS LOS PRODUCTOS AL PEDIDO
                        foreach (XElement x in documentoP.Descendants("producto"))
                        {
                            pedido.Add(x);
                        }
                        document.Save(rutaPedidos);
                    }
                }
                File.Delete(rutaAux);
            }
        }
    }
}