using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System {

    class ArticuloItemCollection : System.Collections.CollectionBase {

        private string _CajeroId;
        private ArticuloItem _SelectedItem;

        public ArticuloItemCollection(string CajeroId) {
            _CajeroId = CajeroId;
        }

        public double SubTotal {
            get {
                //Realizar la suma del Total de cada articulo de la lista 
                var Total = (from ArticuloItem iArticulo in this.List
                             where iArticulo.IsDeleted == false
                             select iArticulo.Total).Sum();

                return Total;
            }
        }

        public string CajeroId {
            get {//Obtener el Cajero Id con la que se inicio la cobranza
                return _CajeroId;
            }
        }

        public ArticuloItem SelectedItem {//Indicar que elemento de la lista esta seleccionado
            get {
                return _SelectedItem;
            }
            set {
                this.ClearSelection();
                _SelectedItem = value;
                _SelectedItem.IsSelected = true;
            }
        }

        public ArticuloItem SelectNext() {
            if (this.Count > 0) {//Si tiene elementos
                var Element = (ArticuloItem)this.List[
                    //Calcular que la sig. posicion no sea mayor a la lista
                                                              (_SelectedItem.Position + 1) >= this.Count ? this.Count - 1 : _SelectedItem.Position + 1
                                                           ];

                if (Element != null) {
                    _SelectedItem = Element;
                }

                if (!_SelectedItem.IsSelected) {
                    this.ClearSelection();//Limpiar cualquier elemento seleccionado
                    _SelectedItem.IsSelected = true;
                }

            }

            return _SelectedItem;
        }

        public ArticuloItem SelectPrev() {

            if (this.Count > 0) {//Si tiene elementos
                var Element = (ArticuloItem)this.List[
                    //Calcular que la posicion anterior no sea menor a 0
                                                              (_SelectedItem.Position - 1) < 0 ? 0 : _SelectedItem.Position - 1
                                                           ];

                if (Element != null) {
                    _SelectedItem = Element;
                }

                if (!_SelectedItem.IsSelected) {
                    this.ClearSelection();//Limpiar cualquier elemento seleccionado
                    _SelectedItem.IsSelected = true;
                }


            }

            return _SelectedItem;
        }

        public ArticuloItem Add(ArticuloItem ArticuloItem) {
            //Agregamos el elemento a la lista 
            int Index = this.List.Add(ArticuloItem);

            //Le indicamos al elemento que posicion tiene
            ArticuloItem.Position = Index;

            return ArticuloItem;//Retornamos el mismo elemento insertado ala lista.
        }

        public void ClearSelection() {
            //Reseteamos el Background Color de cada elemento de la lista.
            this.List.Cast<ArticuloItem>().ToList().ForEach((iArticulo) => {
                iArticulo.IsSelected = false;
            });
        }

    }

}
