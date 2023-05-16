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
    public class ManejadorVacunacionVaca
    {
        AccesoVacunacionVaca Ab = new AccesoVacunacionVaca();
        AccesoVacas Av = new AccesoVacas();
        AccesoMedicamento Am = new AccesoMedicamento();
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

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.ColumnHeadersHeight = 40;
            tabla.DataSource = Ab.Mostrar(filtro).Tables["MedicamentoVacas"];
            tabla.Columns.Insert(4, g.Boton("Editar", Color.FromArgb(137, 249, 59)));
            tabla.Columns.Insert(5, g.Boton("Borrar", Color.FromArgb(251, 42, 9)));
            tabla.Columns[0].Visible = false;
        }
        public void ExtraerMedicamento(ComboBox caja)
        {
            caja.DataSource = Am.Mostrar("").Tables["almacenmedicamento"];
            caja.DisplayMember = "Nombre";
            caja.ValueMember = "id";
        }
        public void ExtraerVacca(ComboBox caja)
        {
            caja.DataSource = Av.Mostrar("").Tables["Vacas"];
            caja.DisplayMember = "arete";
            caja.ValueMember = "arete";
        }
    }
}
