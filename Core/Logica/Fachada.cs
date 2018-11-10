using System;
using System.Collections.Generic;
using System.Text;
using Presentacion.ValueObjects;
using Persistencia.DAO;

namespace Logica
{
    public class Fachada : IfachadaWin, IfachadaWeb
    {
        public void AltaCategoria (CategoriaVO catvo)
        {
            CategoriaDAO catdao = new CategoriaDAO();
            catdao.InsertarCategoria(catvo);
        }

    }
}
