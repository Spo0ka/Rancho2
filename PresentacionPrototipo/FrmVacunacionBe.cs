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
    public partial class FrmVacunacionBe : Form
    {
      public static  MedicamentoBecerro Mb = new MedicamentoBecerro(0,"",0,"");
        public static string Medicamento = "";
        ManejadorVacunacionBecerro Vb;
        int fila, columna;
        public FrmVacunacionBe()
        {
            InitializeComponent();
            Vb = new ManejadorVacunacionBecerro();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAddMedicacionBe frmAddVacunacionBe = new FrmAddMedicacionBe();
            Mb.Id = -1;
            frmAddVacunacionBe.ShowDialog();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Vb.Mostrar(DtgMostrar,TxtBuscar.Text);
        }

        private void DtgMostrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            Mb.Id = int.Parse(DtgMostrar.Rows[fila].Cells[0].ToString());
            Mb.Becerro = DtgMostrar.Rows[fila].Cells[1].ToString();
            Medicamento =DtgMostrar.Rows[fila].Cells[2].ToString();
            Mb.Fecha = DtgMostrar.Rows[fila].Cells[3].ToString();
            switch (columna)
            {
                case 4: { FrmAddMedicacionBe frmAddVacunacionBe = new FrmAddMedicacionBe();
                        frmAddVacunacionBe.ShowDialog();
                    } break;
                    case 5: { Vb.Borrar(Mb.Id); } break;  
                default:
                    break;
            }
        }

        private void DtgMostrar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }
    }
}
