using ConectarBd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AccesoVacunacionBecerro
    {
        Base b = new Base("localhost", "root", "", "GM");

        public void Borrar(dynamic Entidad)
        {
            b.comando(string.Format("Delete from medicamentobecerro where Id = {0}", Entidad.Id));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("Call insertMedBecerro({0},'{1}',{2},'{3}')", Entidad.Id, Entidad.Becerro, Entidad.Medicamento,Entidad.Fecha));
        }

        public DataSet Mostrar(string Filtro)
        {
            return b.Obtener(string.Format("CSELECT * FROM ver_medicamentobecerro WHERE Fk_becerro like '%{0}%'", Filtro), "medicamentobecerro");

        }
    }
}
