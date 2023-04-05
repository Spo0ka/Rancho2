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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void TsbBecerros_Click(object sender, EventArgs e)
        {
            FrmBecerros frmBecerros = new FrmBecerros();
            frmBecerros.ShowDialog();
        }

        private void TsbVacas_Click(object sender, EventArgs e)
        {
            FrmVacas frmVacas = new FrmVacas();
            frmVacas.ShowDialog();
        }

        private void TsbForraje_Click(object sender, EventArgs e)
        {
            FrmForraje frmForraje = new FrmForraje();
            frmForraje.ShowDialog();
        }

        private void TsbMedicamento_Click(object sender, EventArgs e)
        {
            FrmMedicamento frmMedicamento = new FrmMedicamento();
            frmMedicamento.ShowDialog();
        }

        private void TsbVacunacionBe_Click(object sender, EventArgs e)
        {
            FrmVacunacionBe frmAddVacunacionBe = new FrmVacunacionBe();
            frmAddVacunacionBe.ShowDialog();
        }

        private void TsbVacuncionVa_Click(object sender, EventArgs e)
        {
            FrmVacunacionVa frmAddVacunacionVa = new FrmVacunacionVa();
            frmAddVacunacionVa.ShowDialog();
        }

        private void TsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
