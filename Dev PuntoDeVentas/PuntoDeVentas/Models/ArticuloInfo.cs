using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuntoDeVentas.Models {

    //CLASE PARA GUARDAR LA INFORMACION DE UN ARTICULO 
    public class ArticuloInfo {
        public string ID {get;set;}
        public string DESCRIPCION { get; set; }
        public string PRECIO { get; set; }
        public string ES_INVENTARIADO { get; set; }
        public string UNIDAD { get; set; }
        public bool EXIST { get; set; } //SI EL ARTICULO EXISTE DEVUELVE TRUE
        public ImageInfo FOTO{ get; set; }  //INFORMACION DE LA FOTO DEL ARTICULO
        public InventarioInfo INVENTARIO {get;set;} //INFORMACION DEL INVENTARIO

        public ArticuloInfo() {
            this.INVENTARIO = new InventarioInfo();
            this.FOTO =  new ImageInfo();
            this.Clear();
        }

        public void Clear() {
            ID = "";
            DESCRIPCION = "";
            PRECIO = "";
            ES_INVENTARIADO = "";
            UNIDAD = "";
            EXIST = false;
            FOTO.Clear();
            INVENTARIO.Clear();

        }

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
