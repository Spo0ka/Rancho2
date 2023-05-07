using ConectarBd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AccesoTareas
    {
        Base b = new Base("localhost", "root", "", "GM");

        public void Borrar(dynamic Entidad)
        {
            b.comando(string.Format("DELETE FROM agregartareas WHERE id = {0}", Entidad.Id));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("Call InsertTareas({0},'{1}',{2})", Entidad.Id, Entidad.Nombre, Entidad.Usuario));
        }

        public DataSet Mostrar(string Filtro)
        {
            return b.Obtener(string.Format("Call MostrarTareasUsuarios('%{0}%')", Filtro), "agregartareas");

        }
    }
}

