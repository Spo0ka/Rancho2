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
            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
            panel1.BackColor = ColorTranslator.FromHtml("#E08E36");
        }
    }
}
