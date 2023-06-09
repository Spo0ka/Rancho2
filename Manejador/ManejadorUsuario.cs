﻿using AccesoDatos;
using crud;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorUsuario : IManejador
    {
        AccesoUsuarios usuarios = new AccesoUsuarios();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show("¿Desea eliminar este registro?", "Atención!", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                usuarios.Borrar(Entidad);
            }
        }

        public void guardar(dynamic Entidad)
        {
           usuarios.Guardar(Entidad);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.ColumnHeadersHeight = 40;
            tabla.DataSource = usuarios.Mostrar(filtro).Tables["Usuarios"];
            tabla.Columns.Insert(6, g.Boton("Editar", Color.FromArgb(137, 249, 59)));
            tabla.Columns.Insert(7, g.Boton("Borrar", Color.FromArgb(251, 42, 9)));
            tabla.Columns[0].Visible = false;
        }
    }
}
