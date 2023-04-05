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
    public class ManejadorVacunacionBecerro
    {
        AccesoVacunacionBecerro Ab = new AccesoVacunacionBecerro();
        AccesoMedicamento Am = new AccesoMedicamento();
        AccesoBecerros ABB = new AccesoBecerros();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show("Cuidado!", "¿Estás seguro de borrar?", MessageBoxButtons.YesNo);
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
            tabla.DataSource = Ab.Mostrar(filtro).Tables["vacunacionbecerro"];
            tabla.Columns.Insert(4, g.Boton("Editar", Color.FromArgb(137, 249, 59)));
            tabla.Columns.Insert(5, g.Boton("Borrar", Color.FromArgb(251, 42, 9)));
            tabla.Columns[0].Visible = false;
        }
        public void ExtraerMedicamento(ComboBox caja) 
        {
            caja.DataSource = Am.Mostrar("%").Tables["almacenmedicamento"];
            caja.DisplayMember = "NombreDelProducto";
            caja.ValueMember = "id";
        }
        public void ExtraerBecerro(ComboBox caja)
        {
            caja.DataSource = ABB.Mostrar("%").Tables["becerros"];
            caja.DisplayMember = "arete";
            caja.ValueMember = "arete";
        }

    }
}
