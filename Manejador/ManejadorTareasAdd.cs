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
    public class ManejadorTareasAdd : IManejador
    {
        //DESCOMENTAR, CUANDO EL CÓDIGO ACCESO DATOS ESTÉ HECHO
        //AccesoTareas at = new AccesoTareas();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show("Atención!", "¿Desea eliminar este registro?", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                //at.Borrar(Entidad);
            }
        }

        public void guardar(dynamic Entidad)
        {
            //at.Guardar(Entidad);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.ColumnHeadersHeight = 40;
            //tabla.DataSource = at.Mostrar(filtro).Tables["agregartareas"];
            tabla.Columns.Insert(3, g.Boton("Editar", Color.FromArgb(137, 249, 59)));
            tabla.Columns.Insert(4, g.Boton("Borrar", Color.FromArgb(251, 42, 9)));
            tabla.Columns[0].Visible = false;
        }
    }
}
