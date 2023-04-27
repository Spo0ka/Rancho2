using EntidadesPrototipo;
using Manejador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            string pattern = @"^[a-zA-Z]{3}\d{5}$";
            try
            {
                if (txtArete.Text == "")
                {
                    MessageBox.Show("No puedes dejar en blanco el arete");
                }
                else if (!Regex.IsMatch(txtArete.Text, pattern))
                {
                    MessageBox.Show("El formato de entrada no es valido, gonorrea");
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
    }
}
