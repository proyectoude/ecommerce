using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public abstract class Usuario
    {

        // Atributos
        private int idUsuario;

        // Properties
        public int IdUsuario { get { return idUsuario; } }
        public String Email { get; set; }
        public String Password { get; set; }
        public Boolean Activo { get; set; }

        // Constructores
        public Usuario(int id, String mail, String pass, Boolean activo)
        {
            idUsuario = id;
            Email = mail;
            Password = pass;
            Activo = activo;
        }


    }
}
