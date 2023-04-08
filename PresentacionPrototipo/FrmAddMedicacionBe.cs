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
    public partial class FrmAddMedicacionBe : Form
    {
        public FrmAddMedicacionBe()
        {
            InitializeComponent();
        }

        private void FrmAddMedicacionBe_Load(object sender, EventArgs e)
        {
            btnGuardar.BackColor = ColorTranslator.FromHtml("#FFF689");
            panel1.BackColor = ColorTranslator.FromHtml("#E08E36");
        }
    }
}
