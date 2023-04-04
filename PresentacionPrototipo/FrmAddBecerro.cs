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
    public partial class FrmAddBecerro : Form
    {
        ManejadorBecerros Mb;
        public FrmAddBecerro()
        {
            InitializeComponent();
            Mb = new ManejadorBecerros();
            if (FrmBecerros.b.Arete != "-1")
            {
                TxtArete.Text = FrmBecerros.b.Arete;
                TxtFdn.Text = FrmBecerros.b.Fdn;
                TxtPeso.Text = FrmBecerros.b.Peso;
                TxtRaza.Text = FrmBecerros.b.Raza;
                CmbSexo.Text = FrmBecerros.b.Sexo;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Becerro b = new Becerro("", "", "", "", "");
            b.Arete = TxtArete.Text;
            b.Raza = TxtRaza.Text;
            b.Fdn = TxtFdn.Text;
            b.Peso = TxtPeso.Text;
            b.Sexo = CmbSexo.Text;
            Mb.guardar(b);
            Close();
        }
    }
}
