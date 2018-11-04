using System;
using System.Collections.Generic;
using System.Text;

namespace Presentacion.ValueObjects
{
    class CategoriaVO
    {
        // Atributos
        private int idCategoria;
        private String nombre;
        private String descripcion;

        // Properties
        public int IdCategoria { get { return idCategoria; } }
        public string Nombre { get { return nombre; } }
        public string Descripcion { get { return descripcion; } }

        // Constructores
        public CategoriaVO(int idc, string nom, string desc)
        {
            idCategoria = idc;
            nombre = nom;
            descripcion = desc;
        }
    }
}
