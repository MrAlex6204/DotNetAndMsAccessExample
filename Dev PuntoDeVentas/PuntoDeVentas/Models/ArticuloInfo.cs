using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuntoDeVentas.Models {

    //Estructura para guardar la informacion de un articulo 
    public class ArticuloInfo {
        public string ID;
        public string DESCRIPCION;
        public string PRECIO;
        public string INV;
        public string UNIDAD;
        public bool EXIST;//si el articulo existe devuelve true

        public string ToString(double Cantidad) {
            var ArticuloDesc = string.Format(
                                             "{4}\n" +
                                             "Cant: {0} @ ${1} = {2} Unidad: {5} Codigo: {3}",
                                            Cantidad.ToString("0.00"),
                                            Double.Parse(this.PRECIO),
                                            (Double.Parse(this.PRECIO) * Cantidad).ToString("0.00"),
                                            this.ID,
                                            this.DESCRIPCION,
                                            this.UNIDAD
                                            );

            return ArticuloDesc;
        }
        
    }

}
