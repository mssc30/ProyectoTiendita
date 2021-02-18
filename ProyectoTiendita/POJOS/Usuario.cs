using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTiendita.POJOS
{
    /// <summary>
    /// POJO QUE REPRESENTA UN USUARIO CON SUS ATRIBUTOS Y CONSTRUCTOR
    /// </summary>
    public class Usuario
    {
        String usuario { get; set; }
        String contrasena { get; set; }
        String nombre { get; set; }
        String apellidos { get; set; }
        String telefono { get; set; }

        public Usuario(String usuario, String contrasena, String nombre, String apellidos, String telefono)
        {
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
        }
    }
}