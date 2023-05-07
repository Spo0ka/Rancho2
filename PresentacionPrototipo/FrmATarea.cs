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
    public partial class FrmATarea : Form
    {
        ManejadorTareasAdd mt;
        public static AgregarTareas entidad = new AgregarTareas(0,"",0);
        public static int Usuario;
        int fila, col;
        public FrmATarea()
        {
            InitializeComponent();
            mt = new ManejadorTareasAdd();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            entidad.Id = -1;
            FrnAddTareas addt = new FrnAddTareas();
            addt.ShowDialog();
            Actualizar();
        }

        private void dgtTareasA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            switch (col)
            {
                case 3:
                    {
                        entidad.Id = int.Parse(dgtTareasA.Rows[fila].Cells[0].Value.ToString());
                        entidad.Nombre = dgtTareasA.Rows[fila].Cells[1].Value.ToString();
                        Usuario = int.Parse(dgtTareasA.Rows[fila].Cells[2].Value.ToString());

                        FrnAddTareas adt = new FrnAddTareas();
                        adt.ShowDialog();
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
                case 4:
                    {
                        mt.Borrar(entidad);
                        txtBuscar.Text = "";
                        Actualizar();
                    }
                    break;
                default: break;
            }
        }

        private void dgtTareasA_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }

        private void FrmATarea_Load(object sender, EventArgs e)
        {
            btnSalir.BackColor = ColorTranslator.FromHtml("#FF8C67");
            Actualizar();
        }

        void Actualizar()
        {
            mt.Mostrar(dgtTareasA, txtBuscar.Text);
        }
    }
}
