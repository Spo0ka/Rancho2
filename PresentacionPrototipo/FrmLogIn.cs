using AccesoDatos;
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
    public partial class FrmLogIn : Form
    {
        AccesoUsuarios au;
        public FrmLogIn()
        {
            InitializeComponent();
            au = new AccesoUsuarios();
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml("#E08E36");
            btnLogIn.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmPrincipal Principal = new FrmPrincipal();
            Principal.ShowDialog();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var ds = au.MostrarUsuario(txtUsuario.Text);
            var dt = new DataTable();
            dt = ds.Tables[0];
            if (!txtUsuario.Text.Equals(""))
            {
                if (!txtPW.Text.Equals(""))
                {
                    try
                    {
                        if (dt.Rows[0]["Usuario"].ToString().Equals(txtUsuario.Text) && dt.Rows[0]["pass"].ToString().Equals(txtPW.Text))
                        {
                            if (dt.Rows[0]["permisos"].ToString().Equals("Administrador"))
                            {
                                FrmMenuPro Admin = new FrmMenuPro();
                                Admin.ShowDialog();
                            }
                            else if (dt.Rows[0]["permisos"].ToString().Equals("Empleado"))
                            {
                                FrmMenuTrabajador Trabajador = new FrmMenuTrabajador();
                                Trabajador.ShowDialog();
                            }
                        }
                        else if (dt.Rows[0]["Usuario"].ToString().Equals(txtUsuario.Text) && !dt.Rows[0]["pass"].ToString().Equals(txtPW.Text))
                            MessageBox.Show("Contraseña incorrecta");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("El usuario ingresado no existe");
                    }
                }
                else MessageBox.Show("No se ha ingresado una contraseña");
            }
            else
                MessageBox.Show("No se ha ingresado un usuario");
        }
    }
}
