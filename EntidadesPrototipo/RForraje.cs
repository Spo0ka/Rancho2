using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPrototipo
{
    public class RForraje
    {
        public RForraje(int id, int fK_Forraje, string cantidad)
        {
            Id = id;
            FK_Forraje = fK_Forraje;
            Cantidad = cantidad;
        }

        public int Id { get; set; }
        public int FK_Forraje { get; set; }
        public string Cantidad { get; set; }
    }
}
