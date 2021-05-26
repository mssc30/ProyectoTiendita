using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTiendita.POJOS
{
    /// <summary>
    /// POJO QUE REPRESENTA UN CLIENTE, CON SUS ATRIBUTOS Y CONSTRUCTOR
    /// </summary>
    /// 
    [Serializable]
    public class Cliente
    {
        public String nombre { get; set; }
        public String apellidos { get; set; }
        public String direccion { get; set; }
        public String telefono { get; set; }
        public String email { get; set; }
        public String contrasena { get; set; }

        public Cliente(String nombre, String apellidos, String direccion, String telefono, String email, String contrasena)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.contrasena = contrasena;
        }

        public Cliente() { }
    }
}