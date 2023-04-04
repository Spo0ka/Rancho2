using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using crud;

namespace Manejador
{
    public class ManejadorBecerros : IManejador
    {
        AccesoBecerros Ab = new AccesoBecerros();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show("Cuidado!","¿Estás seguro de borrar?",MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                Ab.Borrar(Entidad);
            }
        }

        public void guardar(dynamic Entidad)
        {
            Ab.Guardar(Entidad);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear(); //error
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = Ab.Mostrar(filtro).Tables["becerros"];
           tabla.Columns.Insert(5, g.Boton("Editar", Color.FromArgb(137, 249, 59)));
            tabla.Columns.Insert(6, g.Boton("Borrar", Color.FromArgb(251, 42, 9)));
            
        }
    }
}
