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
    public partial class FrmVacunacionVa : Form
    {
     public static MedicamentoVaca Mv = new MedicamentoVaca(0,"",0,"");
        ManejadorVacunacionVaca Mvv;
      public static string Medicamento = "";
        int Fila, Columna;

        public FrmVacunacionVa()
        {
            InitializeComponent();
            Mvv = new ManejadorVacunacionVaca();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Mvv.Mostrar(DtgMostrar,TxtBuscar.Text);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmMedicacionVaca frmAddVacunacionVa = new FrmMedicacionVaca();
            Mv.Id = -1;
            frmAddVacunacionVa.ShowDialog();
        }

        private void DtgMostrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Mv.Id = int.Parse(DtgMostrar.Rows[Fila].Cells[0].Value.ToString());
            Mv.Vaca = DtgMostrar.Rows[Fila].Cells[1].Value.ToString();
            Medicamento = DtgMostrar.Rows[Fila].Cells[2].Value.ToString();
            Mv.Fecha = DtgMostrar.Rows[Fila].Cells[3].Value.ToString();
            switch (Columna)
            {
                case 4: { FrmMedicacionVaca frmAddVacunacionVa = new FrmMedicacionVaca();
                        frmAddVacunacionVa.ShowDialog();
                    } break;
                case 5: { Mvv.Borrar(Mv.Id);} break; 
                default:
                    break;
            }
        }

        private void DtgMostrar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Fila = e.RowIndex;
            Columna = e.ColumnIndex;
        }
    }
}
