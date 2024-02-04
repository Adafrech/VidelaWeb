using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerEntity
{ 
    public class Product
    {
        public int ID_Producto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public TradeMark oTrademark { get; set; }
        public Category oCategory { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string ImagenRuta { get; set; }
        public string ImagenNombre { get; set; }
        public bool Activo { get; set; }
    }
}
