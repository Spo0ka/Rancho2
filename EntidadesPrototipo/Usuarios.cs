using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPrototipo
{
    public class Usuarios
    {
        public Usuarios(int id, string nombre, string apellido, string usuario, string pSWD, string permisos)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Usuario = usuario;
            PSWD = pSWD;
            Permisos = permisos;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuario { get; set; }
        public string PSWD { get; set; }
        public string Permisos { get; set; }
    }
}
