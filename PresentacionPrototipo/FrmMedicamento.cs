﻿using EntidadesPrototipo;
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
    public partial class FrmMedicamento : Form
    {
        public static AlmacenMedicamento entidad = new AlmacenMedicamento(0,"",0);
        int columna, fila;
        ManejadorMedicamento Mm;
        public FrmMedicamento()
        {
            InitializeComponent();
            Mm = new ManejadorMedicamento();
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
            FrmAddMedicamento medicamento = new FrmAddMedicamento();
            medicamento.ShowDialog();
            Actualizar();
        }

        private void dgtMedicamento_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void dgtMedicamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            entidad.Id = int.Parse(dgtMedicamento.Rows[fila].Cells[0].Value.ToString());
            entidad.Nombre = dgtMedicamento.Rows[fila].Cells[1].Value.ToString();
            entidad.Cantidad = int.Parse(dgtMedicamento.Rows[fila].Cells[2].Value.ToString());

            switch (columna)
            {

                case 3:
                    {

                        FrmAddMedicamento medicamentoa = new FrmAddMedicamento();
                        medicamentoa.ShowDialog();
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
                case 4:
                    {
                        Mm.Borrar(entidad);
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
            }
        }

        private void FrmMedicamento_Load(object sender, EventArgs e)
        {
            if (FrmMenuTrabajador.verifyWorker==true)
                btnAdd.Visible=false;
            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
            panel1.BackColor = ColorTranslator.FromHtml("#E08E36");
            Actualizar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        void Actualizar()
        {
            if (FrmMenuTrabajador.verifyWorker == true)
                Mm.MostrarEmpleados(dgtMedicamento,txtBuscar.Text);
            else
            Mm.Mostrar(dgtMedicamento, txtBuscar.Text);
        }
    }
}
