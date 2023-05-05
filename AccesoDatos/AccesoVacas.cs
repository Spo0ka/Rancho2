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
        Base b = new Base("localhost", "root", "", "GM");

        public void Borrar(dynamic Entidad)
        {
            b.comando(string.Format("DELETE FROM vacas WHERE vacas.Arete ='{0}'", Entidad.Arete));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("Call insertVacas('{0}','{1}','{2}','{3}',{4})", Entidad.Arete, Entidad.Raza,Entidad.Fdn, Entidad.Peso,
                Entidad.LitrosLeche));
        }

        public DataSet Mostrar(string Filtro)
        {
            return b.Obtener(string.Format(" SELECT * FROM vacas WHERE Arete LIKE '%{0}%'", Filtro), "vacas");
            
        }
    }
}
