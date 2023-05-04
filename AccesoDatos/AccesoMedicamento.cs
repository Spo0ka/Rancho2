using ConectarBd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesPrototipo;

namespace AccesoDatos
{
    public class AccesoMedicamento
    {
        Base b = new Base("localhost", "root", "", "GM");

        public void Borrar(dynamic Entidad)
        {
            b.comando(string.Format("DELETE FROM almacenmedicamento WHERE id = {0}", Entidad.Id));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("Call insertAlmacenMedicamento({0},'{1}',{2})", Entidad.Id, Entidad.Nombre, Entidad.Cantidad));
        }

        public DataSet Mostrar(string Filtro)
        {
            return b.Obtener(string.Format("SELECT * FROM almacenmedicamento where Nombre like '%{0}%'", Filtro), "almacenmedicamento");

        }
    }
}
