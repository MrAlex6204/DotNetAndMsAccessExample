using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{

    public class ArticuloItemCollection : System.Collections.CollectionBase
    {

        private ArticuloItem _SelectedItem;

        //DELEGADO CUANDO EL SELECTED ITEM CAMBIO
        public delegate void OnSelectedItemChangeHanlder(ArticuloItem e);
        //DECLARACION DE EVENTO QUE NOS SERVIRA PARA NOTIFICAR CUANDO EL ITEM SELECCIONADO CAMBIO
        public event OnSelectedItemChangeHanlder OnSelectedItemChange;

        public double SubTotal
        {
            get
            {
                //Realizar la suma del Total de cada articulo de la lista 
                var Total = (from ArticuloItem iArticulo in this.List
                             where iArticulo.IsDeleted == false
                             select iArticulo.Total).Sum();

                return Total;
            }
        }

        public ArticuloItem SelectedItem
        {//Indicar que elemento de la lista esta seleccionado
            get
            {
                return _SelectedItem;
            }
            set
            {
                this.ClearSelection();
                _SelectedItem = value;
                _SelectedItem.IsSelected = true;

                if (OnSelectedItemChange != null)
                {
                    //INVOCAR EVENTO CUANDO EL ITEM SELECCIONADO CAMBIO
                    OnSelectedItemChange.Invoke(_SelectedItem);
                }

            }
        }

        public ArticuloItem SelectNext()
        {
            if (this.Count > 0)
            {//Si tiene elementos
                var Element = (ArticuloItem)this.List[
                        //Calcular que la sig. posicion no sea mayor a la lista
                        (this.SelectedItem.Position + 1) >= this.Count ? this.Count - 1 : this.SelectedItem.Position + 1
                ];

                if (Element != null)
                {
                    this.SelectedItem = Element;
                }

                if (!this.SelectedItem.IsSelected)
                {
                    this.ClearSelection();//Limpiar cualquier elemento seleccionado
                    this.SelectedItem.IsSelected = true;
                }

            }

            return this.SelectedItem;
        }

        public ArticuloItem SelectPrev()
        {

            if (this.Count > 0)
            {//Si tiene elementos
                var Element = (ArticuloItem)this.List[
                       //Calcular que la posicion anterior no sea menor a 0
                       (this.SelectedItem.Position - 1) < 0 ? 0 : this.SelectedItem.Position - 1
                    ];

                if (Element != null)
                {
                    this.SelectedItem = Element;
                }

                if (!this.SelectedItem.IsSelected)
                {
                    this.ClearSelection();//Limpiar cualquier elemento seleccionado
                    this.SelectedItem.IsSelected = true;
                }


            }

            return this.SelectedItem;
        }

        public ArticuloItem Add(ArticuloItem ArticuloItem)
        {
            //Agregamos el elemento a la lista 
            int Index = this.List.Add(ArticuloItem);

            //Le indicamos al elemento que posicion tiene
            ArticuloItem.Position = Index;
            ArticuloItem.Location = new Drawing.Point(0, ArticuloItem.Height * this.Count);

            return ArticuloItem;//Retornamos el mismo elemento insertado ala lista.
        }

        public void ClearSelection()
        {
            //Reseteamos el Background Color de cada elemento de la lista.
            this.List.Cast<ArticuloItem>().ToList().ForEach((iArticulo) =>
            {
                iArticulo.IsSelected = false;
            });
        }

    }

}
