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
        

        public DateTime FechaVenta { get; set; }

        public virtual List<DetalleFactura> Discos { get; set; }
        public Factura()
        {
            this.Discos = new List<DetalleFactura>();

        }
        public Factura(int idfactura,int idcliente,DateTime fechaventa )
        {
            this.IdFactura = idfactura;
            this.IdCliente = idcliente;
            this.FechaVenta = fechaventa;
            this.Discos = new List<DetalleFactura>();    
        }
    }
}
