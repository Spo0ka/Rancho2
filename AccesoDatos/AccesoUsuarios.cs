using ConectarBd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class AccesoUsuarios
    {
        Base b = new Base("localhost", "root", "", "GM");

        public void Borrar(dynamic Entidad)
        {
            b.comando(string.Format("DELETE FROM Usuarios WHERE id = {0}", Entidad.Id));
        }

        public void Guardar(dynamic Entidad)
        {
            b.comando(string.Format("CALL insertUsuario({0},'{1}','{2}','{3}','{4}','{5}')", Entidad.Id, Entidad.Nombre, Entidad.Apellido, Entidad.Usuario, Entidad.PSWD, Entidad.Permisos));
        }

        public DataSet Mostrar(string Filtro)
        {
            return b.Obtener(string.Format("SELECT * FROM Usuarios WHERE Nombre LIKE ('%{0}%')", Filtro), "Usuarios");

        }
    }
}
