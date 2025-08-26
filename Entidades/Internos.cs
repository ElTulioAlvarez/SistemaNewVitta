using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Internos
    {
        public int IdInterno { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ocupacion { get; set; }
        public string FamiliarResponsable { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int IdPsicologo { get; set; }
        public int IdDoctor { get; set; }
        public int idUsuario { get; set; }
    }
}
