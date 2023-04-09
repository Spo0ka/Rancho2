﻿using ConectarBd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AccesoVacunacionVaca
    {
        Base b = new Base("localhost", "root", "", "GM");

        public void Borrar(dynamic Entidad)
        {
            b.comando(string.Format("DELETE * FROM medicamentovacas WHERE medicamentovacas.id = {0}", Entidad.Id));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("Call insertMedicamentoVacas({0},'{1}',{2},'{3}')", Entidad.Id, Entidad.Vaca, Entidad.Medicamento, Entidad.Fecha));
        }

        public DataSet Mostrar(string Filtro)
        {
            return b.Obtener(string.Format("SELECT * FROM ver_medicamentoVacas WHERE Fk_vacas LIKE '%{0}%')", Filtro), "MedicamentoVacas");

        }
    }
}
