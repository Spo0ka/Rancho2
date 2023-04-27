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
    public partial class FrmAddForraje : Form
    {
        ManejadorForraje mf;
        public FrmAddForraje()
        {
            InitializeComponent();
            mf = new ManejadorForraje();
            if (FrmForraje.entidad.Id >0)
            {
                txtnombre.Text = FrmForraje.entidad.Nombre;
                txtcantidad.Text = FrmForraje.entidad.Cantidad.ToString();
            }
        }

        private void FrmAddForraje_Load(object sender, EventArgs e)
        {
            btnSubir.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnGuardar.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
            panel1.BackColor = ColorTranslator.FromHtml("#E08E36");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcantidad.Text == "")
                {
                    MessageBox.Show("No puedes dejar casillas en Blanco","Advertencia!!",MessageBoxButtons.OK);
                }
                else if(txtnombre.Text =="")
                {
                    MessageBox.Show("No puedes dejar casillas en Blanco", "Advrtencia", MessageBoxButtons.OK);
                }
                else
                {
                    mf.guardar(new AlmacenForraje(FrmForraje.entidad.Id,txtnombre.Text,int.Parse(txtcantidad.Text)));
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
                pbForraje.Image = Image.FromFile(fo.FileName);
            }
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Mire bien mijo donde escribe", MessageBoxButtons.OK);
                e.Handled = true;
                return;
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("En esta casilla solo se permiten Letras", "Advertencia!!", MessageBoxButtons.OK);
                e.Handled = true;
                return;
            }
        }
    }
}
