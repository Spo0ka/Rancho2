using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPrototipo
{
    public class AgregarTareas
    {
        public AgregarTareas(int id, string nombre, int usuario)
        {
            Id = id;
            Nombre = nombre;
            Usuario = usuario;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Usuario { get; set; }
    }
}
