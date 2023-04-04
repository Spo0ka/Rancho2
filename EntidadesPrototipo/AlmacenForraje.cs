using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPrototipo
{
    public class AlmacenForraje
    {
        public AlmacenForraje(int id, string nombre, int cantidad)
        {
            Id = id;
            Nombre = nombre;
            Cantidad = cantidad;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
    }
}
