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
    public partial class FrmAddBecerro : Form
    {
        ManejadorBecerros mb;
        public FrmAddBecerro()
        {
            InitializeComponent();
            mb = new ManejadorBecerros();
        }

        private void FrmAddBecerro_Load(object sender, EventArgs e)
        {
            btnAceptar.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnSubir.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
            panel1.BackColor = ColorTranslator.FromHtml("#E08E36");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtArete.Text == "")
                {
                    MessageBox.Show("No puedes dejar en blanco el arete");
                }
                else
                {
                    mb.guardar(new Becerro(txtArete.Text, txtRaza.Text,
                        mtxtfdN.Text, txtpeso.Text, txtSexo.Text));
                    Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Al parecer todo bien");
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();
            if (rs == DialogResult.OK)
            {
                pbbcerro.Image = Image.FromFile(fo.FileName);
            }
        }

        private void txtpeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <=47)||(e.KeyChar >=58 && e.KeyChar <=255))
            {
                MessageBox.Show("Solo numeros", "Mire bien mijo donde escribe", MessageBoxButtons.OK);
                e.Handled = true;
                return;
            }
        }
    }
}
