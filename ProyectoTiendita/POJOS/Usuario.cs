using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTiendita.POJOS
{
    /// <summary>
    /// POJO QUE REPRESENTA UN USUARIO CON SUS ATRIBUTOS Y CONSTRUCTOR
    /// </summary>
    /// 
    [Serializable]
    public class Usuario
    {
        public String usuario { get; set; }
        public String contrasena { get; set; }
        public String nombre { get; set; }
        public String apellidos { get; set; }
        public String telefono { get; set; }

        public Usuario(String usuario, String contrasena, String nombre, String apellidos, String telefono)
        {
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
        }

        public Usuario() { }
    }
}