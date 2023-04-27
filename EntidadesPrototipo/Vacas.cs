using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPrototipo
{
    public class Vacas
    {
        public Vacas(string arete, string raza, string fdn ,string peso, string litrosLeche)
        {
            Arete = arete;
            Raza = raza;
            Fdn = fdn;
            Peso = peso;
            LitrosLeche = litrosLeche;
        }

        public string Arete { get; set; }
        public string Raza { get; set; }
        public string Fdn { get; set; }
        public string Peso { get; set; }
        public string LitrosLeche { get; set; }
    }
}
