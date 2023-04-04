using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
namespace AccesoDatos
{
    public class AccesoTareasAsignadas : Iconexion
    {
        Base b = new Base("localhost", "root", "", "gm");
        public void Borrar(dynamic Entidad)
        {
            b.comando(string.Format("CALL deleteTareasAsig({0})",Entidad.Id));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("CALL insertTareasAsignadas({0}, {1})", Entidad.Id, Entidad.Tarea));
        }

        public DataSet Mostrar(string Filtro)
        {
            return b.Obtener(string.Format("CALL showTareasAsig(%{0}%)", Filtro), "agregartareas");
        }
    }
}
