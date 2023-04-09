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
    public partial class FrmAddMedicamento : Form
    {
        public FrmAddMedicamento()
        {
            InitializeComponent();
        }

        private void FrmAddMedicamento_Load(object sender, EventArgs e)
        {
            btnSubir.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnAceptar.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
            panel1.BackColor = ColorTranslator.FromHtml("#E08E36");
        }
    }
}
