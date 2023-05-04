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
    public partial class FrmMenuPro : Form
    {
        public FrmMenuPro()
        {
            InitializeComponent();
        }

        private void FrmMenuPro_Load(object sender, EventArgs e)
        {
            btnAlmForraje.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnAlmMedicamento.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnBecerro.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnForraje.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnTareas.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnVacas.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnVacBecerros.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnVacVacas.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnAgregarTarea.BackColor = ColorTranslator.FromHtml("#FFF689");
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
            FrmVacas Vaca = new FrmVacas();
            Vaca.ShowDialog();
        }

        private void btnBecerro_Click(object sender, EventArgs e)
        {
            FrmBecerros Becerro = new FrmBecerros();
            Becerro.ShowDialog();
        }

        private void btnVacVacas_Click(object sender, EventArgs e)
        {
            FrmVacunacionVa VVacas = new FrmVacunacionVa();
            VVacas.ShowDialog();
        }

        private void btnVacBecerros_Click(object sender, EventArgs e)
        {
            FrmVacunacionBe VBecerros = new FrmVacunacionBe();
            VBecerros.ShowDialog();
        }

        private void btnForraje_Click(object sender, EventArgs e)
        {
            FrmRForraje RForraje = new FrmRForraje();
            RForraje.ShowDialog();
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            FrmATarea AgregarT = new FrmATarea();
            AgregarT.ShowDialog();
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

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.ShowDialog();
        }
    }
}
