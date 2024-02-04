using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerEntity
{ 
    internal class User
    {
        public int ID_User { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Acesso { get; set; }
        public bool Reseteo {  get; set; }
        public bool Activo { get; set; }


    }
}
