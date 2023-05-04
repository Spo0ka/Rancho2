using AccesoDatos;
using crud;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorMedicamento
    {
        AccesoMedicamento Ab = new AccesoMedicamento();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show("Atención!", "¿Desea eliminar este registro?", MessageBoxButtons.YesNo);
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
            tabla.Columns.Clear(); 
            tabla.RowTemplate.Height = 30;
            tabla.ColumnHeadersHeight = 40;
            tabla.DataSource = Ab.Mostrar(filtro).Tables["almacenmedicamento"];
            tabla.Columns.Insert(3, g.Boton("Editar", Color.FromArgb(137, 249, 59)));
            tabla.Columns.Insert(4, g.Boton("Borrar", Color.FromArgb(251, 42, 9)));
            tabla.Columns[0].Visible = false;
        }
    }
}
