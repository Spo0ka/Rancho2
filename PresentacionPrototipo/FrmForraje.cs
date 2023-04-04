using EntidadesPrototipo;
using Manejador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionPrototipo
{
    public partial class FrmForraje : Form
    {
       public static AlmacenForraje F = new AlmacenForraje(0,"",0);
        ManejadorForraje Mf;
        int fila, columna;
        public FrmForraje()
        {
            InitializeComponent();
            Mf = new ManejadorForraje();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAddForraje frmAddForraje = new FrmAddForraje();
            F.Id = -1;
            frmAddForraje.ShowDialog();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Mf.Mostrar(DtgMostrar,TxtBuscar.Text);
        }

        private void DtgMostrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            F.Id = int.Parse(DtgMostrar.Rows[fila].Cells[0].Value.ToString());
            F.Nombre = DtgMostrar.Rows[fila].Cells[1].Value.ToString();
            F.Cantidad = int.Parse(DtgMostrar.Rows[fila].Cells[2].Value.ToString());
            switch (columna)
            {
                case 3: { FrmAddForraje frmAddForraje = new FrmAddForraje();
                        frmAddForraje.ShowDialog();
                    } break;
                case 4: { Mf.Borrar(F.Id); } break;
                default:
                    break;
            }
        }

        private void DtgMostrar_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }
    }
}
