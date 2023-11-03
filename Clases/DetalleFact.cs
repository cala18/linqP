using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linqP.Clases
{
    public class DetalleFact
    {
        public int ID { get; internal set; }
        public int NumeroFactura { get; internal set; }
        public int IDProducto { get; internal set; }
        public int Cantidad { get; internal set; }
        public decimal Valor { get; internal set; }
    }
}