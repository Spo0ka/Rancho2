using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesPrototipo;
using Manejador;

namespace PresentacionPrototipo
{
    public partial class FrmBecerros : Form
    {
        ManejadorBecerros Mb;
     public static Becerro b = new Becerro("","","","","");
        int columna, fila;
        public FrmBecerros()
        {
            InitializeComponent();
            Mb = new ManejadorBecerros();
        }

        private void FrmBecerros_Load(object sender, EventArgs e)
        {

            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
        }
    }
}
