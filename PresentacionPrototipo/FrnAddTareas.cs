using System;
using Manejador;
using EntidadesPrototipo;
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
    public partial class FrnAddTareas : Form
    {
        ManejadorTareasAdd mt;
        public FrnAddTareas()
        {
            InitializeComponent();
            mt = new ManejadorTareasAdd();
            if (FrmATarea.entidad.Id>0)
            {
                txtTarea.Text = FrmATarea.entidad.Nombre;
            }
        }

        private void FrnAddTareas_Load(object sender, EventArgs e)
        {
            btnGuardar.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
            panel1.BackColor = ColorTranslator.FromHtml("#E08E36");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mt.guardar(new AgregarTareas(FrmATarea.entidad.Id,
                txtTarea.Text));
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
