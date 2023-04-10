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
    public partial class FrmForraje : Form
    {
       public static AlmacenForraje entidad = new AlmacenForraje(0,"",0);
        ManejadorForraje Mf;
        int fila, columna;
        public FrmForraje()
        {
            InitializeComponent();
            Mf = new ManejadorForraje();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            entidad.Id = -1;
            FrmAddForraje addf = new FrmAddForraje();
            addf.ShowDialog();
            Actualizar();
        }

        private void dgtForraje_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            entidad.Id = int.Parse(dgtForraje.Rows[fila].Cells[0].Value.ToString());
            entidad.Nombre = dgtForraje.Rows[fila].Cells[1].Value.ToString();
            entidad.Cantidad = int.Parse(dgtForraje.Rows[fila].Cells[2].Value.ToString());
            switch (columna)
            {
                case 3:
                    {
                        FrmAddForraje adf = new FrmAddForraje();
                        adf.ShowDialog();
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
                case 4:
                    {
                        Mf.Borrar(entidad);
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
            }
        }

        private void dgtForraje_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }

        private void FrmForraje_Load(object sender, EventArgs e)
        {
            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
            Actualizar();
        }
        void Actualizar()
        {
            Mf.Mostrar(dgtForraje, txtBuscar.Text);
        }
    }
}
