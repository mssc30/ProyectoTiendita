using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTiendita.POJOS
{
    public class PedidoAux
    {
        public String id { get; set; }
        public String descripcion { get; set; }
        public Double total { get; set; }

        public String usuario { get; set; }

        public PedidoAux(string id, string descripcion, double total, String usuario)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.total = total;
            this.usuario = usuario;
        }
    }
}