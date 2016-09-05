using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuntoDeVentas.Models {

   public class Usuario {
               
        public virtual int Id { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Nombre { get; set; }
        public virtual string Type { get; set; }
        
    }


}
