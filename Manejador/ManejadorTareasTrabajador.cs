using crud;
using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorTareasTrabajador : IManejador
    {
        //DESCOMENTAR, CUANDO EL CÓDIGO ACCESO DATOS ESTÉ HECHO
        AccesoTareasR att = new AccesoTareasR();
        AccesoTareas at = new AccesoTareas();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show("Atención!", "¿Desea eliminar este registro?", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                att.Borrar(Entidad);
            }
        }

        public void guardar(dynamic Entidad)
        {
            att.Guardar(Entidad);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.ColumnHeadersHeight = 40;
            tabla.DataSource = att.Mostrar(filtro).Tables["tarear"];
            tabla.Columns.Insert(4, g.Boton("Editar", Color.FromArgb(137, 249, 59)));
            tabla.Columns.Insert(5, g.Boton("Borrar", Color.FromArgb(251, 42, 9)));
            tabla.Columns[0].Visible = false;
        }
        public void ExportarTareas(ComboBox caja)
        {
           caja.DataSource = at.Mostrar("").Tables["agregartareas"];
            caja.DisplayMember = "Tarea";
            caja.ValueMember = "id";
        }
    }
}
