using System;
using System.Collections.Generic;
using System.Text;

namespace Presentacion.ValueObjects
{
    public class BackofficeVO : UsuarioVO
    {
        // Atributos
        private String nombre;
        private String rol;
        
        // Properties
        public String Nombre { get { return nombre; } }
        public String Rol { get { return rol; } }

        // Constructores
        public BackofficeVO(String nom, String rol, int id, string mail, string pass, Boolean activo) : base(id, mail, pass, activo)
        {
            nombre = nom;
            this.rol = rol;
        }
    }
}
