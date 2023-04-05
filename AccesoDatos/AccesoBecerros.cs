using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
using EntidadesPrototipo;

namespace AccesoDatos
{
    public class AccesoBecerros : Iconexion
    {
        Base b = new Base("localhost","root","","rn");

        public void Borrar(dynamic Entidad)
        {
            b.comando(string.Format("Call DeleteBecerros('{0}')",Entidad.Arete));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("Call InsertBecerro('{0}','{1}','{2}','{3}','{4}')", Entidad.Arete,Entidad.Raza, Entidad.Fdn, 
                Entidad.Peso, Entidad.Sexo));
        }

        public DataSet Mostrar(string Filtro)
        {
            return b.Obtener(string.Format("Call ShowBecerros('%{0}%')",Filtro),"becerros");
        }
    }
}
