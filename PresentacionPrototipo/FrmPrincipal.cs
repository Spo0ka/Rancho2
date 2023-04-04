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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            btnIngresar.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnIngresar.ForeColor = ColorTranslator.FromHtml("#D1931A");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
