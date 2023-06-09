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
    public partial class FrmAddMedicamento : Form
    {
        ManejadorMedicamento mm;
        public FrmAddMedicamento()
        {
            InitializeComponent();
            mm = new ManejadorMedicamento();
            if (FrmMedicamento.entidad.Id >0)
            {
                txtNombre.Text = FrmMedicamento.entidad.Nombre;
                txtCantidad.Text = FrmMedicamento.entidad.Cantidad.ToString();
            }
        }

        private void FrmAddMedicamento_Load(object sender, EventArgs e)
        {
            btnSubir.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnAceptar.BackColor = ColorTranslator.FromHtml("#FFF689");
            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
            panel1.BackColor = ColorTranslator.FromHtml("#E08E36");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("No puedes dejar casillas en Blanco", "Advertencia!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtCantidad.Text =="")
                {
                    MessageBox.Show("No puedes dejar casillas en Blanco", "Advertencia!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    mm.guardar(new AlmacenMedicamento(FrmMedicamento.entidad.Id, txtNombre.Text, int.Parse(txtCantidad.Text)));
                    Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Acaso aparece esto?");
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();
            if (rs == DialogResult.OK)
            {
                pbMedicamento.Image = Image.FromFile(fo.FileName);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("En esta casilla solo se permiten Letras", "Advertencia!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("En esta casilla solo se permite Numeros", "Advertencia!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
    }
}
