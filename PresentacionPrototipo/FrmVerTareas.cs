using System;
using EntidadesPrototipo;
using Manejador;
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
    public partial class FrmVerTareas : Form
    {
        ManejadorTareasTrabajador mtt;
        public static TareaR entidad = new TareaR(0, 0, "","");
        public static string Tarea = "";
        public static string usuario = "";
        int fila, col;
        public FrmVerTareas()
        {
            InitializeComponent();
            mtt = new ManejadorTareasTrabajador();
        }

        private void FrmVerTareas_Load(object sender, EventArgs e)
        {
            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
            panel1.BackColor = ColorTranslator.FromHtml("#E08E36");
            Actualizar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            entidad.Id = -1;
            FrmTareas fr = new FrmTareas();
            fr.ShowDialog();
            Actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgtTareasR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            entidad.Id = int.Parse(dgtTareasR.Rows[fila].Cells[0].Value.ToString());
            Tarea = dgtTareasR.Rows[fila].Cells[1].Value.ToString();
            entidad.Cumplio = dgtTareasR.Rows[fila].Cells[2].Value.ToString();
            usuario = dgtTareasR.Rows[fila].Cells[3].Value.ToString();
            switch (col)
            {
                case 4:
                    {
                        FrmTareas ft = new FrmTareas();
                        ft.ShowDialog();
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
                case 5:
                    {
                        mtt.Borrar(entidad);
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
                default: break;
            }
        }

        private void dgtTareasR_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }
        void Actualizar()
        {
            mtt.Mostrar(dgtTareasR, txtBuscar.Text);
        }
    }
}
