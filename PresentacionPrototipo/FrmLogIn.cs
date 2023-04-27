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
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml("#E08E36");
            btnLogIn.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmPrincipal Principal = new FrmPrincipal();
            Principal.ShowDialog();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtPW.Text == "1234" && txtUsuario.Text == "Admin")
            {
                FrmMenuPro Admin = new FrmMenuPro();
                Admin.ShowDialog();
            }

           if(txtPW.Text == "4321" && txtUsuario.Text == "Trabajador")
            {
                FrmMenuTrabajador Trabajador = new FrmMenuTrabajador();
                Trabajador.ShowDialog();
            }
           else
                MessageBox.Show("Error de Usuario");

        }
    }
}
