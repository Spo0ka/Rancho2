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
            string pattern = @"^[a-zA-Z]{3}\d{5}$";
            try
            {
                if (txtArete.Text == "")
                {
                    MessageBox.Show("No puedes dejar en blanco las casillas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtPeso.Text == "")
                {
                    MessageBox.Show("No puedes dejar en blanco las casillas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtRaza.Text == "")
                {
                    MessageBox.Show("No puedes dejar en blanco las casillas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtLecheL.Text == "")
                {
                    MessageBox.Show("No puedes dejar en blanco las casillas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (mtxtFdn.Text == "")
                {
                    MessageBox.Show("No puedes dejar en blanco las casillas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!Regex.IsMatch(txtArete.Text, pattern))
                {
                    MessageBox.Show("El formato de entrada no es Valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtRaza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("En esta casilla solo se permiten Letras", "Advertencia!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("En esta casilla solo se permite Numeros", "Advertencia!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void mtxtFdn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("En esta casilla solo se permite Numeros", "Advertencia!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtLecheL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("En esta casilla solo se permite Numeros", "Advertencia!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
    }
  
}
