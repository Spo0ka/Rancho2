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
    public partial class FrmAddMedicacionBe : Form
    {
        ManejadorVacunacionBecerro mv;
        public FrmAddMedicacionBe()
        {
            InitializeComponent();
            mv = new ManejadorVacunacionBecerro();
            mv.ExtraerMedicamento(cmbMedicamento);
            mv.ExtraerBecerro(cmbNombre);
            if (FrmVacunacionBe.entidad.Id >0)
            {
                cmbNombre.Text = FrmVacunacionBe.entidad.Becerro;
                cmbMedicamento.Text = FrmVacunacionBe.entidad.Medicamento.ToString();
                mtxtFecha.Text = FrmVacunacionBe.entidad.Fecha;
            }
        }

        private void FrmAddMedicacionBe_Load(object sender, EventArgs e)
        {
            btnGuardar.BackColor = ColorTranslator.FromHtml("#FFF689");
            panel1.BackColor = ColorTranslator.FromHtml("#E08E36");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtxtFecha.Text == "")
                {
                    MessageBox.Show("No puedes dejar casillas en Blanco", "Advertencia!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cmbMedicamento.SelectedIndex ==-1)
                {
                    MessageBox.Show("No olvides seleccionar una opción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cmbNombre.SelectedIndex == -1)
                {
                    MessageBox.Show("No olvides seleccionar una opción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    mv.guardar(new MedicamentoBecerro(FrmVacunacionBe.entidad.Id,cmbNombre.SelectedValue.ToString(), int.Parse(cmbMedicamento.SelectedValue.ToString()),
                    mtxtFecha.Text));
                    Close();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Acaso aparece esto?");
            } 
        }

        private void mtxtFecha_KeyPress(object sender, KeyPressEventArgs e)
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
