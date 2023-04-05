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
    public partial class FrmMedicamento : Form
    {
      public static AlmacenMedicamento M = new AlmacenMedicamento(0,"",0);
        int columna, fila;
        ManejadorMedicamento Mm;
        public FrmMedicamento()
        {
            InitializeComponent();
            Mm = new ManejadorMedicamento();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAddMedicamento frmAddMedicamento = new FrmAddMedicamento();
            M.Id = -1;
            frmAddMedicamento.ShowDialog();

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Mm.Mostrar(DtgMostrar,TxtBuscar.Text);
        }

        

        private void DtgMostrar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }
        private void DtgMostrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            M.Id = int.Parse(DtgMostrar.Rows[fila].Cells[0].Value.ToString());
            M.Nombre = DtgMostrar.Rows[fila].Cells[1].Value.ToString();
            M.Cantidad = int.Parse(DtgMostrar.Rows[fila].Cells[2].Value.ToString());
            switch (columna)
            {
                case 3: { FrmAddMedicamento frmAddMedicamento = new FrmAddMedicamento();
                        frmAddMedicamento.ShowDialog();
                    }
            break;
                case 4: { Mm.Borrar(M.Id); } break;
                default:
                    break;
        }
    }
}
}
