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
    public partial class FrmVacas : Form
    {
       public static Vacas V = new Vacas("","","","");
        ManejadorVaca Mv;
        int fila, columna;
        public FrmVacas()
        {
            InitializeComponent();
            Mv = new ManejadorVaca();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmVacas_Load(object sender, EventArgs e)
        {

            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
        }
    }
}
