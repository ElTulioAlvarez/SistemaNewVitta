using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medicamentos
    {
        public int IdMedicamento { get; set; }
        public string Nombre { get; set; }
        public string Dosis { get; set; }
        public string Frecuencia { get; set; }
        public int id_usuario { get; set; }
    }
}
