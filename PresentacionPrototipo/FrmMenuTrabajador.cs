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
    public partial class FrmMenuTrabajador : Form
    {
        public static bool verifyWorker = true;
        public FrmMenuTrabajador()
        {
            verifyWorker = true;
            InitializeComponent();
        }

        private void FrmMenuTrabajador_Load(object sender, EventArgs e)
        {
            btnTareas.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnVacas.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnForraje.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnBecerro.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnAlmMedicamento.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnAlmForraje.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
            panel1.BackColor = ColorTranslator.FromHtml("#E08E36");
        }

        private void btnAlmForraje_Click(object sender, EventArgs e)
        {
            FrmForraje Forraje = new FrmForraje();
            Forraje.ShowDialog();
        }

        private void btnAlmMedicamento_Click(object sender, EventArgs e)
        {
            FrmMedicamento Medicamento = new FrmMedicamento();
            Medicamento.ShowDialog();
        }

        private void btnVacas_Click(object sender, EventArgs e)
        {
            FrmVacunacionVa VVaca = new FrmVacunacionVa();
            VVaca.ShowDialog();
        }

        private void btnBecerro_Click(object sender, EventArgs e)
        {
            FrmVacunacionBe VBecerro = new FrmVacunacionBe();
            VBecerro.ShowDialog();
        }

        private void btnForraje_Click(object sender, EventArgs e)
        {
            FrmRForraje RForraje = new FrmRForraje();
            RForraje.ShowDialog();
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            FrmVerTareas TareasR = new FrmVerTareas();
            TareasR.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
