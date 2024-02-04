using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerEntity
{ 
    internal class ShopCart
    {
        public int ID_Carrito { get; set; }
        public Client oClient { get; set; }
        public Product oProduct { get; set; }
        public int Cantidad { get; set; }

    }
}
