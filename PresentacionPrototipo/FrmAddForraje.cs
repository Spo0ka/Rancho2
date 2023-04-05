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
        ManejadorForraje Mf;
        public FrmAddForraje()
        {
            InitializeComponent();
            Mf = new ManejadorForraje();
            if (FrmForraje.F.Id>0)
            {
                TxtCantidad.Text = FrmForraje.F.Cantidad.ToString();
                TxtNombre.Text = FrmForraje.F.Nombre;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            AlmacenForraje F = new AlmacenForraje(0, "", 0);
            F.Id = FrmForraje.F.Id;
            F.Cantidad = int.Parse(TxtCantidad.Text);
            F.Nombre = TxtNombre.Text;
            Mf.guardar(F);
            Close();
        }
    }
}
