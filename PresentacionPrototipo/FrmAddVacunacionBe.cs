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
    public partial class FrmAddVacunacionBe : Form
    {
        ManejadorVacunacionBecerro Vb;
        public FrmAddVacunacionBe()
        {
            InitializeComponent();
            Vb = new ManejadorVacunacionBecerro();
            Vb.ExtraerMedicamento(CmbMedicamento);
            Vb.ExtraerBecerro(CmbBecerro);
            if (FrmVacunacionBe.Mb.Id>0)
            {
                CmbBecerro.Text = FrmVacunacionBe.Mb.Becerro;
                TxtFecha.Text = FrmVacunacionBe.Mb.Fecha;
                CmbMedicamento.Text = FrmVacunacionBe.Medicamento; 
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            MedicamentoBecerro Mb = new MedicamentoBecerro(0, "", 0, "");
            Mb.Id = FrmVacunacionBe.Mb.Id;
            Mb.Becerro = CmbBecerro.SelectedValue.ToString();
            Mb.Medicamento =Convert.ToInt32(CmbMedicamento.SelectedValue);
            Mb.Fecha = TxtFecha.Text;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
