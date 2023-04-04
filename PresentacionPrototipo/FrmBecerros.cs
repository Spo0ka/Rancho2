using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesPrototipo;
using Manejador;

namespace PresentacionPrototipo
{
    public partial class FrmBecerros : Form
    {
        ManejadorBecerros Mb;
     public static Becerro b = new Becerro("","","","","");
        int columna, fila;
        public FrmBecerros()
        {
            InitializeComponent();
            Mb = new ManejadorBecerros();
        }

        private void DtgMostrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            b.Arete = DtgMostrar.Rows[fila].Cells[0].Value.ToString();
            b.Raza = DtgMostrar.Rows[fila].Cells[1].Value.ToString();
            b.Fdn = DtgMostrar.Rows[fila].Cells[2].Value.ToString();
            b.Peso = DtgMostrar.Rows[fila].Cells[3].Value.ToString();
            b.Sexo = DtgMostrar.Rows[fila].Cells[4].Value.ToString();
            switch (columna)
            {
                case 5: { FrmAddBecerro frmAddBecerro = new FrmAddBecerro();
                        frmAddBecerro.ShowDialog();
                    } break;
                case 6: { Mb.Borrar(b.Arete); } break;
                default:
                    break;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAddBecerro frmAddBecerro = new FrmAddBecerro();
            b.Arete = "-1";
            frmAddBecerro.ShowDialog();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            Mb.Mostrar(DtgMostrar,TxtBuscar.Text);
        }

        private void DtgMostrar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            columna = e.ColumnIndex;
            fila = e.RowIndex;
        }
    }
}
