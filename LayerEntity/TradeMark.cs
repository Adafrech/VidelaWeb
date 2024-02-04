using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LayerEntity
{

    public class TradeMark
    {
        public int ID_Marca { get; set; }

        public string Descripcion { get; set; }
        public bool Activo { get; set; }
    }
}
