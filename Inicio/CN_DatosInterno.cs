using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Conexion;

namespace Inicio
{
    public class CN_DatosInterno
    {
        private DatosInterno objDatosInterno = new DatosInterno();

        public List<Internos> Listar()
        {
            return objDatosInterno.Listar();
        }
    }
}
