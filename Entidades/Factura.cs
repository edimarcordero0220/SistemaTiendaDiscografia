using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class Factura
    {
        [Key]
        public int IdFactura { get; set; }
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string NombreDisco { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaVenta { get; set; }
       // public int Total { get; set; }


        // public virtual ICollection<Factura> Detalle { get; set; } //Muchos






        public virtual List<Discos> Discos { get; set; }
        public Factura()
        {
            this.Discos = new List<Discos>();
            //this.Detalle = new HashSet<Factura>();

        }
        public Factura(int idfactura,int idcliente,DateTime fechaventa,decimal precio )
        {
            this.IdFactura = idfactura;
            this.IdCliente = idcliente;
            this.FechaVenta = fechaventa;
            this.Precio = precio;
            this.Discos = new List<Discos>();    
        }
    }
}
