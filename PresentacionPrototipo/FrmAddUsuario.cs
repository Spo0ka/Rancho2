using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesPrototipo;
using Manejador;
namespace PresentacionPrototipo
{
   
    public partial class FrmAddUsuario : Form
    {
        ManejadorUsuario Mu;
        public FrmAddUsuario()
        {
            InitializeComponent();
            Mu= new ManejadorUsuario();
            if (FrmUsuarios.Usuarios.Id > 0)
            {
                txtApellidos.Text = FrmUsuarios.Usuarios.Apellido;
                txtNombre.Text = FrmUsuarios.Usuarios.Nombre;
                cmbPermisos.Text = FrmUsuarios.Usuarios.Permisos.ToString();
                Txtpsw.Text = FrmUsuarios.Usuarios.PSWD;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text =="")
                {
                    MessageBox.Show("No puedes dejar casillas en Blanco", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(txtApellidos.Text == "")
                {
                    MessageBox.Show("No puedes dejar casillas en Blanco", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Txtpsw.Text == "")
                {
                    MessageBox.Show("No puedes dejar casillas en Blanco", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cmbPermisos.SelectedIndex == -1)
                {
                    MessageBox.Show("No olvides seleccionar una opción", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Mu.guardar(new Usuarios(FrmUsuarios.Usuarios.Id, txtNombre.Text, txtApellidos.Text, "", Txtpsw.Text, cmbPermisos.Text));
                    Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Acaso aparece esto?");
            }
            
        }

        private void FrmAddUsuario_Load(object sender, EventArgs e)
        {
            btnGuardar.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
            panel1.BackColor = ColorTranslator.FromHtml("#E08E36");
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96))
            {
                MessageBox.Show("En esta casilla solo se permiten Letras", "Advertencia!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96))
            {
                MessageBox.Show("En esta casilla solo se permiten Letras", "Advertencia!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
