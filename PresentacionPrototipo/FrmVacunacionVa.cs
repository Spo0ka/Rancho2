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
    public partial class FrmVacunacionVa : Form
    {
     public static MedicamentoVaca Mv = new MedicamentoVaca(0,"",0,"");
        ManejadorVacunacionVaca Mvv;
      public static string Medicamento = "";
        int Fila, Columna;

        public FrmVacunacionVa()
        {
            InitializeComponent();
            Mvv = new ManejadorVacunacionVaca();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmVacunacionVa_Load(object sender, EventArgs e)
        {

            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
        }
    }
}
