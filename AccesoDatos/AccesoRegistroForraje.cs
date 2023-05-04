using ConectarBd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AccesoRegistroForraje
    {
       
        Base b = new Base("localhost", "root", "", "GM");

        public void Borrar(dynamic Entidad)
        {
            b.comando(string.Format("DELETE FROM registroforraje WHERE id = {0}", Entidad.Id));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("Call insertRegistroForraje({0},{1},'{2}')",Entidad.Id, Entidad.FK_Forraje, Entidad.Cantidad));
        }

        public DataSet Mostrar(string Filtro)
        {
            return b.Obtener(string.Format("SELECT * FROM RegistroForraje WHERE cantidad like ('%{0}%')", Filtro), "RegistroForraje");

        }
    }
}

