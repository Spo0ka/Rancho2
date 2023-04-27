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
                txtApellidos.Text= FrmUsuarios.Usuarios.Apellido.ToString();
                txtNombre.Text = FrmUsuarios.Usuarios.Nombre.ToString();
                TxtPermisos.Text = FrmUsuarios.Usuarios.Permisos.ToString();
                Txtpsw.Text = FrmUsuarios.Usuarios.PSWD.ToString();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Mu.guardar(new Usuarios(FrmUsuarios.Usuarios.Id,txtNombre.Text,txtApellidos.Text,"",Txtpsw.Text,TxtPermisos.Text));
            Close();
        }
    }
}
