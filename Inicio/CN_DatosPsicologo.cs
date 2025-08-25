using Conexion;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio
{
    public class CN_DatosPsicologo
    {
        private DatosPsicologo objDatosPsicologo = new DatosPsicologo();

        public List<Psicologos> Listar()
        {
            return objDatosPsicologo.Listar();
        }
    }
}
