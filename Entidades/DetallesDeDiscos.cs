using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetallesDeDiscos
    {
        public int IdDetalleDisco{ get; set; }
        public int IdDisco { get; set; }
        public string Cancion { get; set; }
        public string DuracionDeLaCancion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
