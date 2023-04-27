using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPrototipo
{
    public class TareaR
    {
        public TareaR(int id, int idTarea, string cumplio)
        {
            Id = id;
            IdTarea = idTarea;
            Cumplio = cumplio;
        }

        public int Id { get; set; }
        public int IdTarea { get; set; }
        public string Cumplio { get; set; }
    }
}
