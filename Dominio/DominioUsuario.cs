using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dominio
{
    public class DominioUsuario
    {
        private Usuario usuario = new Usuario();

        public DataSet mostrar()
        {
            return usuario.mostrar();
        }

        public void Insertar(string id, string nombre, string telefono)
        {
            usuario.Insertar(id, nombre, telefono);
        }

        public string[] Buscar(string id)
        {
            return usuario.Buscar(id);
        }

        public void Actualizar(string id, string nombre, string telefono)
        {
            usuario.Actualizar(id, nombre, telefono);
        }

        public void Eliminar(string id)
        {
            usuario.Eliminar(id);
        }
    }
}
