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
    public partial class FrmVacas : Form
    {
       public static Vacas V = new Vacas("","","","");
        ManejadorVaca Mv;
        int fila, columna;
        public FrmVacas()
        {
            InitializeComponent();
            Mv = new ManejadorVaca();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAddVaca frmAddVaca = new FrmAddVaca();
            V.Arete = "-1";
            frmAddVaca.ShowDialog();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Mv.Mostrar(DtgMostrar, TxtBuscar.Text);
        }

        private void DtgMostrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            V.Arete = DtgMostrar.Rows[fila].Cells[0].Value.ToString();
            V.Raza = DtgMostrar.Rows[fila].Cells[1].Value.ToString();
            V.Peso = DtgMostrar.Rows[fila].Cells[2].Value.ToString();
            V.LitrosLeche = DtgMostrar.Rows[fila].Cells[3].Value.ToString();
            switch (columna)
            {
                case 4: { FrmAddBecerro frmAddBecerro = new FrmAddBecerro();
                        frmAddBecerro.ShowDialog();
                    } break;
                case 5: { Mv.Borrar(V.Arete); } break;
                default: break;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DtgMostrar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }
    }
}
