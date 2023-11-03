using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linqP.Clases
{
    public class Factura
    {
        public int numeroFactura { get; internal set; }
        public DateTime Fecha { get; internal set; }
        public int IDCliente { get; internal set; }
        public decimal TotalFactura { get; internal set; }
    }
}