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
    public partial class FrmForraje : Form
    {
       public static AlmacenForraje F = new AlmacenForraje(0,"",0);
        ManejadorForraje Mf;
        int fila, columna;
        public FrmForraje()
        {
            InitializeComponent();
            Mf = new ManejadorForraje();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void FrmForraje_Load(object sender, EventArgs e)
        {
            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
        }
    }
}
