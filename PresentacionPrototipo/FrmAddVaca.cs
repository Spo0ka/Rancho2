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
    public partial class FrmAddVaca : Form
    {
        ManejadorVaca Mv;
        public FrmAddVaca()
        {
            InitializeComponent();
            Mv = new ManejadorVaca();
            if (FrmVacas.V.Arete != "-1")
            {
                TxtArete.Text = FrmVacas.V.Arete;
                TxtLleche.Text = FrmVacas.V.LitrosLeche;
                TxtPeso.Text = FrmVacas.V.Peso;
                TxtRaza.Text = FrmVacas.V.Raza;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Vacas V = new Vacas("", "", "", "");
            V.Arete = TxtArete.Text;
            V.Raza =TxtRaza.Text;
            V.Peso =TxtPeso.Text;
            V.LitrosLeche =TxtLleche.Text ;
            Mv.guardar(V);
            Close();
        }
    }
}
