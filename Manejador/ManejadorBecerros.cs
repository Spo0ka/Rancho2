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
            DialogResult rs = MessageBox.Show("Atención!","¿Desea eliminar este registro?",MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                Ab.Borrar(Entidad);
            }
        }

        public void guardar(dynamic Entidad)
        {
            Ab.Guardar(Entidad);
        }
        public void editar(dynamic Entidad)
        {
            //Ab.editar(dynamic entidad);
            //Esto se descomentará, cuando el trabajo en acceso datos esté hecho.
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.ColumnHeadersHeight = 40;
            tabla.DataSource = Ab.Mostrar(filtro).Tables["becerro"];
            tabla.Columns.Insert(5, g.Boton("Editar", Color.FromArgb(137, 249, 59)));
            tabla.Columns.Insert(6, g.Boton("Borrar", Color.FromArgb(251, 42, 9)));
            tabla.Columns[0].Visible = false;
        }
    }
}
