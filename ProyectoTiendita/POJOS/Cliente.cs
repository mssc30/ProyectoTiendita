using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTiendita.POJOS
{
    /// <summary>
    /// POJO QUE REPRESENTA UN CLIENTE, CON SUS ATRIBUTOS Y CONSTRUCTOR
    /// </summary>
    public class Cliente
    {
        String nombre { get; set; }
        String apellidos { get; set; }
        String direccion { get; set; }
        String telefono { get; set; }
        String email { get; set; }
        String contrasena { get; set; }

        public Cliente(String nombre, String apellidos, String direccion, String telefono, String email, String contrasena)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.contrasena = contrasena;
        }
    }
}