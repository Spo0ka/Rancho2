using System;
using System.Collections.Generic;
using System.Data;
using ConectarBd;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AccesoTareasR
    {
        Base b = new Base("localhost", "root", "", "GM");

        public void Borrar(dynamic Entidad)
        {
            b.comando(string.Format("DELETE FROM tarear WHERE id = {0}", Entidad.Id));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("Call InsertTareasR({0},{1},'{2}','{3}')", Entidad.Id, Entidad.IdTarea,Entidad.Cumplio, Entidad.Usuario));
        }

        public DataSet Mostrar(string Filtro)
        {
            return b.Obtener(string.Format("call MostrarTareasR('%{0}%')", Filtro), "TareaR");

        }
    }
}
