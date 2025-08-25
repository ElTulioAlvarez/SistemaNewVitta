using Conexion;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    public class CN_DatosDoctor
    {
        private DatosDoctor objDatosDoctor = new DatosDoctor();

        public List<Doctores> Listar()
        {
            return objDatosDoctor.Listar();
        }
    }
}
