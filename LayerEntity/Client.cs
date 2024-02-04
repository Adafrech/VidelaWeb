using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerEntity
{ 
    public class Client
    {
        public int ID_Cliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set;}
        public string Correo { get; set;}
        public string Clave { get; set;}
        public bool Reseteo { get; set;}
    }
}
