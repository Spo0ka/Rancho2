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
       public static Vacas entidad = new Vacas("","","","",0);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            entidad.Arete = "";
            FrmAddVaca nuevav = new FrmAddVaca();
            nuevav.ShowDialog();
            Actualizar();
        }

        private void dgtVacas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            entidad.Arete = dgtVacas.Rows[fila].Cells[0].Value.ToString();
            entidad.Raza = dgtVacas.Rows[fila].Cells[1].Value.ToString();
            entidad.Fdn = dgtVacas.Rows[fila].Cells[2].Value.ToString();
            entidad.Peso = dgtVacas.Rows[fila].Cells[3].Value.ToString();
            entidad.LitrosLeche = double.Parse(dgtVacas.Rows[fila].Cells[4].Value.ToString());

            switch (columna)
            {
                case 5:
                    {
                        FrmAddVaca nuevobe = new FrmAddVaca();
                        nuevobe.ShowDialog();
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
                case 6:
                    {
                        Mv.Borrar(entidad);
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
                default: break;
            }
        }

        private void dgtVacas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void FrmVacas_Load(object sender, EventArgs e)
        {

            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
            panel1.BackColor = ColorTranslator.FromHtml("#E08E36");
            Actualizar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        void Actualizar()
        {
            Mv.Mostrar(dgtVacas, txtBuscar.Text);
        }
    }
}
