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
    public partial class FrmAddMedicamento : Form
    {
        ManejadorMedicamento Mm;
        public FrmAddMedicamento()
        {
            InitializeComponent();
            Mm = new ManejadorMedicamento();
            if (FrmMedicamento.M.Id>0)
            {
                TxtCantidad.Text = FrmMedicamento.M.Cantidad.ToString();
                TxtNombre.Text = FrmMedicamento.M.Nombre;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            AlmacenMedicamento M = new AlmacenMedicamento(0,"",0);
            M.Id = FrmMedicamento.M.Id;
            M.Nombre = TxtNombre.Text;
            M.Cantidad = int.Parse(TxtCantidad.Text);
            Mm.guardar(M);
            Close();
        }
    }
}
