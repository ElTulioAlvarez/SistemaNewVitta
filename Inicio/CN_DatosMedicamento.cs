using Conexion;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    public class CN_DatosMedicamento
    {
        private DatosMedicamento objDatosMedicamento = new DatosMedicamento();

        public List<Medicamentos> Listar()
        {
            return objDatosMedicamento.Listar();
        }
    }
}
