using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    internal interface Iconexion
    {
            void Guardar(dynamic Entidad);
            DataSet Mostrar(string Filtro);
            void Borrar(dynamic Entidad);
    }
}
