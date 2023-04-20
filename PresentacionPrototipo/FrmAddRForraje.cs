using System;
using EntidadesPrototipo;
using Manejador;
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
    public partial class FrmAddRForraje : Form
    {
        ManejadorRForraje mr;
        public FrmAddRForraje()
        {
            InitializeComponent();
            mr = new ManejadorRForraje();
            mr.ExportarForraje(cmbForraje);
            if (FrmRForraje.entidad.Id>0)
            {
                cmbForraje.Text = FrmRForraje.entidad.FK_Forraje.ToString();
                txtCantidad.Text = FrmRForraje.entidad.Cantidad;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mr.guardar(new RForraje(FrmRForraje.entidad.Id,
                int.Parse(cmbForraje.SelectedValue.ToString()),
                txtCantidad.Text));
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAddRForraje_Load(object sender, EventArgs e)
        {
            btnGuardar.BackColor = ColorTranslator.FromHtml("#FFF689");
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Mire bien mijo donde escribe", MessageBoxButtons.OK);
                e.Handled = true;
                return;
            }
        }
    }
}
