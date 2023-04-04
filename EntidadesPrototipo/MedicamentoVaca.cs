using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPrototipo
{
    public class MedicamentoVaca
    {
        public MedicamentoVaca(int id, string vaca, int medicamento, string fecha)
        {
            Id = id;
            Vaca = vaca;
            Medicamento = medicamento;
            Fecha = fecha;
        }

        public int Id { get; set; }
        public string Vaca { get; set; }
        public int Medicamento { get; set; }
        public string Fecha { get; set; }
    }
}
