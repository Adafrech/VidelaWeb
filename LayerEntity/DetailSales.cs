using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerEntity
{ 
    internal class DetailSales
    {
        public int ID_DVenta { get; set; }
        public int ID_Venta { get; set; }
        public Product oProduct { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }

        public string ID_Transaccion { get; set; }
    }
}
