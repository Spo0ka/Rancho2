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
    public partial class FrmAddVaca : Form
    {
        ManejadorVaca Mv;
        public FrmAddVaca()
        {
            InitializeComponent();
            Mv = new ManejadorVaca();
        }

        private void FrmAddVaca_Load(object sender, EventArgs e)
        {
            btnAceptar.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnSubir.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
            panel1.BackColor = ColorTranslator.FromHtml("#E08E36");
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();
            if (rs == DialogResult.OK)
            {
                PbVaca.Image = Image.FromFile(fo.FileName);
            }
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
                    Mv.guardar(new Vacas(txtArete.Text, txtRaza.Text,
                        mtxtFdn.Text, txtPeso.Text, txtLecheL.Text));
                    Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Al parecer todo bien");
            }
        }
    }
  
}
