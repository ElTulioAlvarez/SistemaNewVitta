using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Conexion;

namespace Inicio
{
    public class CN_DatosUsuario
    {
        public class CN_Usuarios
        {
            private DatosUsuario objDatosUsuario = new DatosUsuario();

            public List<Usuarios> Listar()
            {
                return objDatosUsuario.Listar();
            }
        }
    }
}
