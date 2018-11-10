using Modelo.ValueObjects;
using System.Collections.Generic;

namespace LogicaPersistencia.DAO
{
    public class CategoriaDAO
    {
        public void InsertarCategoria(CategoriaVO catvo)
        {
            //aca va el insert y la conexion a la base de datos.    
        }

        public void EliminarCategoria(int catid)
        {
            //aca va el delete y la conexion a la base de datos.    
        }

        public void ModificarCategoria(CategoriaVO catvo)
        {
            //aca va el update y la conexion a la base de datos.    
        }

        public List<CategoriaVO> ListarCategorias()
        {
            return null;
        }

        public CategoriaVO DarCategoria (int catid)
        {
            return null;
        }
    }
}
