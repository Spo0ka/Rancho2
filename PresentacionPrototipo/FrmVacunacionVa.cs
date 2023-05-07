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
     public static MedicamentoVaca entidad = new MedicamentoVaca(0,"",0,"");
        ManejadorVacunacionVaca Mvv;
        public static string Medicamento = "", Vaca = "";
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void dgtVvacas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            switch (Columna)
            {
                case 4:
                    {
                        entidad.Id = int.Parse(dgtVvacas.Rows[Fila].Cells[0].Value.ToString());
                        Vaca = dgtVvacas.Rows[Fila].Cells[1].Value.ToString();
                        Medicamento = dgtVvacas.Rows[Fila].Cells[2].Value.ToString();
                        entidad.Fecha = dgtVvacas.Rows[Fila].Cells[3].Value.ToString();

                        FrmMedicacionVaca vacam = new FrmMedicacionVaca();
                        vacam.ShowDialog();
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
                case 5:
                    {
                        Mvv.Borrar(entidad);
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
                default: break;

            }

        }

        private void dgtVvacas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Fila = e.RowIndex;
            Columna = e.ColumnIndex;
        }

        private void FrmVacunacionVa_Load(object sender, EventArgs e)
        {

            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
            Actualizar();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            entidad.Id = -1;
            FrmMedicacionVaca mvaca = new FrmMedicacionVaca();
            mvaca.ShowDialog();
            Actualizar();
        }

        void Actualizar()
        {
            Mvv.Mostrar(dgtVvacas, txtBuscar.Text);
        }
    }
}
