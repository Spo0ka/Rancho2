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
    public partial class FrmMedicamento : Form
    {
      public static AlmacenMedicamento M = new AlmacenMedicamento(0,"",0);
        int columna, fila;
        ManejadorMedicamento Mm;
        public FrmMedicamento()
        {
            InitializeComponent();
            Mm = new ManejadorMedicamento();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void FrmMedicamento_Load(object sender, EventArgs e)
        {
            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
        }
    }
}
