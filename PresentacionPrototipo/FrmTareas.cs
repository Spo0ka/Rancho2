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
    public partial class FrmTareas : Form
    {
        ManejadorTareasTrabajador mtt;
        public FrmTareas()
        {
            InitializeComponent();
            mtt = new ManejadorTareasTrabajador();
            mtt.ExportarTareas(cmbtarea);
            if (FrmVerTareas.entidad.Id>0)
            {
                cmbtarea.Text = FrmVerTareas.entidad.IdTarea.ToString();
                txtcumplio.Text = FrmVerTareas.entidad.Cumplio;
            }
        }

        private void FrmTareas_Load(object sender, EventArgs e)
        {
            btnGuardar.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
            panel1.BackColor = ColorTranslator.FromHtml("#E08E36");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcumplio.Text == "")
                {
                    MessageBox.Show("No puedes dejar casillas en Blanco", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cmbtarea.SelectedIndex == -1)
                {
                    MessageBox.Show("No olvides seleccionar una opción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Acaso aparece esto?");
            }
            mtt.guardar(new TareaR(FrmVerTareas.entidad.Id,
                int.Parse(cmbtarea.SelectedValue.ToString()),
                txtcumplio.Text));
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtcumplio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("En esta casilla solo se permiten Letras", "Advertencia!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
    }
}
