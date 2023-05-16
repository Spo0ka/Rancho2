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
        public static Becerro entidad = new Becerro("", "", "", "", "");
        int columna, fila;
        public FrmBecerros()
        {
            InitializeComponent();
            Mb = new ManejadorBecerros();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            entidad.Arete = "";
            FrmAddBecerro nuevob = new FrmAddBecerro();
            nuevob.ShowDialog();
            Actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmBecerros_Load(object sender, EventArgs e)
        {

            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
            panel1.BackColor = ColorTranslator.FromHtml("#E08E36");
            Actualizar();
        }

        private void dgtBecerro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            entidad.Arete = dgtBecerro.Rows[fila].Cells[0].Value.ToString();
            entidad.Raza = dgtBecerro.Rows[fila].Cells[1].Value.ToString();
            entidad.Fdn = dgtBecerro.Rows[fila].Cells[2].Value.ToString();
            entidad.Peso = dgtBecerro.Rows[fila].Cells[3].Value.ToString();
            entidad.Sexo = dgtBecerro.Rows[fila].Cells[4].Value.ToString();

            switch (columna)
            {
                case 5:
                    {
                        FrmAddBecerro nuevobe = new FrmAddBecerro();
                        nuevobe.ShowDialog();
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
                case 6:
                    {
                        Mb.Borrar(entidad);
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
                default: break;
            }
        }

        private void dgtBecerro_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        void Actualizar()
        {
            Mb.Mostrar(dgtBecerro, txtBuscar.Text);
        }
    }
}
