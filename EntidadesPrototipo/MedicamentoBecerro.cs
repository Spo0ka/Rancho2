using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPrototipo
{
    public class MedicamentoBecerro
    {
        public MedicamentoBecerro(int id, string becerro, int medicamento, string fecha)
        {
            Id = id;
            Becerro = becerro;
            Medicamento = medicamento;
            Fecha = fecha;
        }

        public int Id { get; set; }
        public string Becerro { get; set; }
        public int Medicamento { get; set; }
        public string Fecha { get; set; }
    }
}
