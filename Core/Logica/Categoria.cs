using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Categoria
    {
        // Atributos
        private int idCategoria;

        // Properties
        public int IdCategoria { get { return idCategoria; } }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
 
        // Constructores
        public Categoria(int idc, string nom, string desc)
        {
            idCategoria = idc;
            Nombre = nom;
            Descripcion = desc;
        }

    }
}
