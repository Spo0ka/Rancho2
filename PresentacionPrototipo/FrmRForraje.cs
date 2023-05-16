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
    public partial class FrmRForraje : Form
    {
        public static RForraje entidad = new RForraje(0, 0, "");
        ManejadorRForraje mf;
        public static string Forraje = "";
        int fila, col;
        public FrmRForraje()
        {
            InitializeComponent();
            mf = new ManejadorRForraje();
        }

        private void dgtRForraje_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            entidad.Id = int.Parse(dgtRForraje.Rows[fila].Cells[0].Value.ToString());
            Forraje = dgtRForraje.Rows[fila].Cells[1].Value.ToString();
            entidad.Cantidad = dgtRForraje.Rows[fila].Cells[2].Value.ToString();
            switch (col)
            {
                case 3:
                    {
                        FrmAddRForraje arf = new FrmAddRForraje();
                        arf.ShowDialog();
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
                case 4:
                    {
                        mf.Borrar(entidad);
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
                default: break;
            }
        }

        private void dgtRForraje_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            entidad.Id = -1;
            FrmAddRForraje rf = new FrmAddRForraje();
            rf.ShowDialog();
            Actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmRForraje_Load(object sender, EventArgs e)
        {
           // btnAdd.Visible=false;
            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
            panel1.BackColor = ColorTranslator.FromHtml("#E08E36");
            Actualizar();
        }
        void Actualizar()
        {
            mf.Mostrar(dgtRForraje, txtBuscar.Text);
        }
    }
}
