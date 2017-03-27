using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Disco
    {
        [Key]
        public int IdDisco { get; set; }
        public string NombreDisco { get; set; }
        public string UsuarioCreador { get; set; }
        public string Artista { get; set; }
        public string Productor { get; set; }
        public string SelloDiscografico { get; set; }
        public DateTime FechaDeLanzamiento { get; set; }
        public DateTime FechaCreacion { get; set; }


        public virtual List<Factura> Factura { get; set; }
        public Disco()
        {
            this.Factura = new List<Entidades.Factura>();
        }
        public Disco(int iddisco, string nombredisco)
        {
            this.IdDisco = iddisco;
            this.NombreDisco = nombredisco;
            this.Factura = new List<Entidades.Factura>();

        }

    }
}
