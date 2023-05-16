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
    public partial class FrmUsuarios : Form
    {
        public static Usuarios Usuarios = new Usuarios(0,"","","","","");
        ManejadorUsuario Mu;
        int fila, col;
        public FrmUsuarios()
        {
            InitializeComponent();
            Mu = new ManejadorUsuario();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgtMedicamento_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }

        private void dgtMedicamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Usuarios.Id = int.Parse(dtgMostrar.Rows[fila].Cells[0].Value.ToString());
            Usuarios.Nombre = dtgMostrar.Rows[fila].Cells[1].Value.ToString();
            Usuarios.Apellido = dtgMostrar.Rows[fila].Cells[2].Value.ToString();
            Usuarios.PSWD = dtgMostrar.Rows[fila].Cells[4].Value.ToString();
            Usuarios.Permisos = dtgMostrar.Rows[fila].Cells[5].Value.ToString();

            switch (col)
            {
                case 6: {
                        FrmAddUsuario frmAddUsuario = new FrmAddUsuario();
                        frmAddUsuario.ShowDialog();
                        txtBuscar.Text = "";
                        Actualizar();
                    } break;
                    case 7: {
                        MessageBox.Show(Usuarios.Id.ToString());
                        Mu.Borrar(Usuarios);
                              txtBuscar.Text = "";
                               Actualizar();
                    } break;
                default:
                    break;
            }
        }
        public void Actualizar() 
        {
            Mu.Mostrar(dtgMostrar,txtBuscar.Text);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
            panel1.BackColor = ColorTranslator.FromHtml("#E08E36");
            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Usuarios.Id = -1;
            FrmAddUsuario frmAddUsuario = new FrmAddUsuario();
            frmAddUsuario.ShowDialog();
        }
    }
}
