using ConectarBd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AccesoVacas : Iconexion
    {
        Base b = new Base("localhost", "root", "", "rn");

        public void Borrar(dynamic Entidad)
        {
            b.comando(string.Format("Call DeleteVacas('{0}')", Entidad.Arete));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("Call InsertVaca('{0}','{1}','{2}','{3}')", Entidad.Arete, Entidad.Raza, Entidad.Peso,
                Entidad.LitrosLeche));
        }

        public DataSet Mostrar(string Filtro)
        {
            return b.Obtener(string.Format("Call ShowVacas('%{0}%')", Filtro), "vacas");
            
        }
    }
}
