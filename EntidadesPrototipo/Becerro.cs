using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPrototipo
{
    public class Becerro
    {
        public Becerro(string arete, string raza, string fdn, string peso, string sexo)
        {
            Arete = arete;
            Raza = raza;
            Fdn = fdn;
            Peso = peso;
            Sexo = sexo;
        }

        public string Arete { get; set; }
        public string Raza { get; set; }
        public string Fdn { get; set; }
        public string Peso { get; set; }
        public string Sexo { get; set; }
    }
}
