using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentas.Models {

    public class InventarioInfo {


        public bool EXISTS { get; set; }
        public string ID { get; set; }
        public double ENTRADA { get; set; }
        public double SALIDA { get; set; }
        public double STOCK { get; set; }


        public InventarioInfo() {
            this.Clear();
        }

        public void Clear() {
            this.EXISTS = false;
            this.ID = string.Empty;
            this.ENTRADA = 0d;
            this.SALIDA = 0d;
            this.STOCK = 0d;
        }



    }
}
