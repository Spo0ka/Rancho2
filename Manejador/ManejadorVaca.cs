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
    public class ManejadorVaca
    {
        AccesoVacas Ab = new AccesoVacas();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show("¿Desea eliminar este registro?", "Atención!", MessageBoxButtons.YesNo);
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
            //Ab.Editar(Entidad);
            //Descomentar, cuando el trabajo de acceso datos se haya realizado.
        }
        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear(); 
            tabla.RowTemplate.Height = 30;
            tabla.ColumnHeadersHeight = 40;
            tabla.DataSource = Ab.Mostrar(filtro).Tables["Vacas"];
            tabla.Columns.Insert(5, g.Boton("Editar", Color.FromArgb(137, 249, 59)));
            tabla.Columns.Insert(6, g.Boton("Borrar", Color.FromArgb(251, 42, 9)));
        }
    }
}

