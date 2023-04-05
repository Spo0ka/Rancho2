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
    public partial class FrmAddVacunacionVa : Form
    {
        ManejadorVacunacionVaca Mvv;
        public FrmAddVacunacionVa()
        {
            InitializeComponent();
            Mvv = new ManejadorVacunacionVaca();
            Mvv.ExtraerVacca(CmbVaca);
            Mvv.ExtraerMedicamento(CmbMedicamento);
            if (FrmVacunacionVa.Mv.Id>0)
            {
                CmbMedicamento.Text = FrmVacunacionVa.Medicamento;
                CmbVaca.Text = FrmVacunacionVa.Mv.Vaca;
                TxtFecha.Text = FrmVacunacionVa.Mv.Fecha;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            MedicamentoVaca Mv = new MedicamentoVaca(0, "", 0, "");
            Mv.Id = FrmVacunacionVa.Mv.Id;
            Mv.Vaca = CmbVaca.SelectedValue.ToString();
            Mv.Medicamento = Convert.ToInt32(CmbVaca.SelectedValue);
            Mv.Fecha = TxtFecha.Text;
            Mvv.guardar(Mv);
            Close();
    }
    }
}
