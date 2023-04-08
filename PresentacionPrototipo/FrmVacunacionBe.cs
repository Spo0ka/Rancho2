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
    public partial class FrmVacunacionBe : Form
    {
      public static  MedicamentoBecerro Mb = new MedicamentoBecerro(0,"",0,"");
        public static string Medicamento = "";
        ManejadorVacunacionBecerro Vb;
        int fila, columna;
        public FrmVacunacionBe()
        {
            InitializeComponent();
            Vb = new ManejadorVacunacionBecerro();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void FrmVacunacionBe_Load(object sender, EventArgs e)
        {

            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
        }
    }
}
