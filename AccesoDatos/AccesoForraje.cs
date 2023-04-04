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
        Base b = new Base("localhost", "root", "", "rn");

        public void Borrar(dynamic Entidad)
        {
            b.comando(string.Format("Call DeleteMedicamento({0})", Entidad.Id));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("Call InsertAlmacenForraje({0},'{1}',{2})", Entidad.Id, Entidad.Nombre, Entidad.Cantidad));
        }

        public DataSet Mostrar(string Filtro)
        {
            return b.Obtener(string.Format("Call ShowForraje('%{0}%')", Filtro), "almacenforraje");

        }
    }
}
