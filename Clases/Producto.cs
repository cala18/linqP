using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linqP.Clases
{
    public class Producto
    {
        public int ID { get; internal set; }
        public string Nombre { get; internal set; }
        public decimal PrecioUnit { get; internal set; }
        public int Cantidad { get; internal set; }
        public int StockMin { get; internal set; }
        public int StockMax { get; internal set; }
    }
}