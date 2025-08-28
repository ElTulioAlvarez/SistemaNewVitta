using Conexion;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    public class CN_DatosInternosMedicamentos
    {
        private DatosInternoMedicamentos objDatosInternoMedicamentos = new DatosInternoMedicamentos();

        public List<InternoMedicamentos> Listar()
        {
            return objDatosInternoMedicamentos.Listar();
        }
    }
}
