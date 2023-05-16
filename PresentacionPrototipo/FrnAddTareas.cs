using System;
using Manejador;
using EntidadesPrototipo;
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
    public partial class FrnAddTareas : Form
    {
        ManejadorTareasAdd mt;
        public FrnAddTareas()
        {
            InitializeComponent();
            mt = new ManejadorTareasAdd();
            mt.ExtraerUsuario(CmbUsuario);
            if (FrmATarea.entidad.Id > 0)
            {
                txtTarea.Text = FrmATarea.entidad.Nombre;
                CmbUsuario.Text = FrmATarea.Usuario;
            }
        }

        private void FrnAddTareas_Load(object sender, EventArgs e)
        {
            btnGuardar.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
            panel1.BackColor = ColorTranslator.FromHtml("#E08E36");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTarea.Text == "")
                {
                    MessageBox.Show("No puedes dejar en blanco las casillas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (CmbUsuario.SelectedIndex == -1)
                {
                    MessageBox.Show("No olvides seleccionar una opción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    mt.guardar(new AgregarTareas(FrmATarea.entidad.Id,
                    txtTarea.Text, int.Parse(CmbUsuario.SelectedValue.ToString())));
                    Close();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTarea_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
