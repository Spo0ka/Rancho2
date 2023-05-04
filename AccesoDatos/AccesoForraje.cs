using ConectarBd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AccesoForraje
    {
        Base b = new Base("localhost", "root", "", "GM");

        public void Borrar(dynamic Entidad)
        {
            b.comando(string.Format("DELETE FROM almacenforraje WHERE id = {0}", Entidad.Id));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("Call agregarForraje({0},'{1}','{2}')", Entidad.Id ,Entidad.Nombre, Entidad.Cantidad));
        }

        public DataSet Mostrar(string Filtro)
        {
            return b.Obtener(string.Format("SELECT * FROM ver_forraje WHERE nombre LIKE '%{0}%'", Filtro), "almacenForraje");

        }
    }
}
