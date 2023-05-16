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
    public partial class FrmVacunacionBe : Form
    {
      public static  MedicamentoBecerro entidad = new MedicamentoBecerro(0,"",0,"");
        public static string Medicamento = "", Becerro = "";
        ManejadorVacunacionBecerro Vb;
        int fila, columna;
        public FrmVacunacionBe()
        {
            InitializeComponent();
            Vb = new ManejadorVacunacionBecerro();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            entidad.Id = -1;
            FrmAddMedicacionBe mbe = new FrmAddMedicacionBe();
            mbe.ShowDialog();
            Actualizar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dgtVBecerro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            entidad.Id = int.Parse(dgtVBecerro.Rows[fila].Cells[0].Value.ToString());
            Becerro = dgtVBecerro.Rows[fila].Cells[1].Value.ToString();
            Medicamento = dgtVBecerro.Rows[fila].Cells[2].Value.ToString();
            entidad.Fecha = dgtVBecerro.Rows[fila].Cells[3].Value.ToString();

            switch (columna)
            {
                case 4:
                    {
                        FrmAddMedicacionBe vacam = new FrmAddMedicacionBe();
                        vacam.ShowDialog();
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
                case 5:
                    {
                        Vb.Borrar(entidad);
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
                default: break;
            }
        }
        private void dgtVBecerro_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void FrmVacunacionBe_Load(object sender, EventArgs e)
        {
            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
            panel1.BackColor = ColorTranslator.FromHtml("#E08E36");
            Actualizar();
        }
        void Actualizar()
        {
            Vb.Mostrar(dgtVBecerro, txtBuscar.Text);
        }
    }
}
