using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuntoDeVentas.Models {

    //CLASE PARA GUARDAR LA INFORMACION DE UN ARTICULO 
    public class ArticuloInfo {
        public string ID;
        public string DESCRIPCION;
        public string PRECIO;
        public string INV;
        public string UNIDAD;
        public bool EXIST;//SI EL ARTICULO EXISTE DEVUELVE TRUE
        public ImageInfo Foto = new ImageInfo(); //INFORMACION DE LA FOTO DEL ARTICULO
        
        //RETORNAR EN TEXTO LA INFORMACION DEL ARTICULO
        public string ToString(double Cantidad) {
            var ArticuloDesc = string.Format(
                                             "{4}\n" +
                                             "Cant: {0} @ ${1} = {2} Unidad: {5} Codigo: {3}",
                                            Cantidad.ToString("0.00"),
                                            Functions.ToCurrency(this.PRECIO),
                                            Functions.ToCurrency((Double.Parse(this.PRECIO) * Cantidad)),
                                            this.ID,
                                            this.DESCRIPCION,
                                            this.UNIDAD
                                            );

            return ArticuloDesc;
        }
        
    }

}
