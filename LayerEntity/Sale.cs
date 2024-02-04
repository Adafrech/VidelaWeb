using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerEntity
{
    internal class Sale
    { 
        public int ID_Venta { get; set; }
        public int ID_Cliente { get; set; }
        public int Total_Producto { get; set; }
        public decimal MontoTotal { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string ID_Transaccion { get; set; }

        public List<DetailSales> oDetailSales { get; set;}
    }
}
