using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    class ItemsCarrito
    {
        // Properties
        public int IdProducto { get; set; }
        public int IdCarrito { get; set; }
        public int Cantidad { get; set; }
        
        // Constructores
        public ItemsCarrito(int idp, int idc, int cant)
        {
            IdProducto = idp;
            IdCarrito = idc;
            Cantidad = cant;
        }


    }
}
