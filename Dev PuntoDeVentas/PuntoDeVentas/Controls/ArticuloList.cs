using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVentas {



    [DefaultEvent("OnListChange")]
    public partial class ArticuloList : UserControl {

        private System.ArticuloItemCollection _LstArticulos = new System.ArticuloItemCollection();

        public delegate void OnChangeHandler(object sender, object e);
        public event OnChangeHandler OnListChange;

        //CREAMOS EL EVENTO DE SELECTED ITEM CHANGE PARA NOTIFICAR CUANDO EL ITEM SELECCIONADO CAMBIO
        public event ArticuloItemCollection.OnSelectedItemChangeHanlder OnSelectedItemChange;
        //CREAMOS EL EVENTO DE ON TRASACTION END PARA NOTIFICAR QUE LA TRANSACCION TERMINO
        public event Controls.SubTotalPanel.OnTransactionEndHandler OnTransactionEnd;

        public struct SubtotalInfo {
            public int Count;
            public double Total;
        }

        public ArticuloList() {

            InitializeComponent();

            if (!this.DesignMode) {//Delete the dummy item
                this.Items.Clear();
                this.pnlCobranzaList.Controls.Clear();
            }

            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.ContainerControl, true);

            if (this.DesignMode) {
                this.BackColor = Color.FromArgb(64, 64, 64);
            }
            //ADJUNTAR EVENTO A LA LISTA CUANDO EL ITEM SELECCIONADO CAMBIO
            this.Items.OnSelectedItemChange += delegate(ArticuloItem e) {

                if (this.OnSelectedItemChange != null) {
                    //INVOCAR EVENTO CUANDO EL ITEM SELECCIONADO CAMBIO
                    this.OnSelectedItemChange.Invoke(e);
                }

            };

            //ADJUNTAR EVENTO PARA CUANDO LA TRANSACCION SE COBRO POR COMPLETO
            this.pnlSubTotal.OnTransactionEnd += delegate(string Total, string Pago, string Cambio) {
                if (this.OnTransactionEnd != null) {
                    this.OnTransactionEnd.Invoke(Total, Pago, Cambio);
                }
            };

        }

        public bool SubTotalPanelVisible {

            get {
                return pnlSubTotal.Visible;
            }
            set {
                this.pnlSubTotal.Clear();
                this.pnlSubTotal.Items = _LstArticulos;
                this.pnlSubTotal.Visible = value;

                if (this.pnlSubTotal.Visible) {
                    if (_LstArticulos.Count > 0) {
                        //HACER SCROLL HASTA EL ITEM SELECCIONADO
                        this.pnlCobranzaList.ScrollControlIntoView(_LstArticulos.SelectedItem);
                    }                    
                }
                                
                this.Invalidate(true);
            }
        }

        public ArticuloItemCollection Items {

            get {

                return _LstArticulos;

            }
            set {
                _LstArticulos = value;
            }
        }

        public void ScrollIntoView(ArticuloItem Item) {
            pnlCobranzaList.ScrollControlIntoView(Item);
        }

        public ArticuloItem Add(ArticuloItem Item) {

            this.Items.Add(Item);//Agregar el item a la lista de articulos

            this.Items.SelectedItem = Item;//Seleccionar el item

            Item.Size = new Size(this.Size.Width, Item.Size.Height);


            pnlCobranzaList.Controls.Add(Item);//Agregar el container a la lista            

            pnlCobranzaList.ScrollControlIntoView(Item);

            _RaiseEvent();

            this.Invalidate(true);
            return Item;
        }

        public ArticuloItem Delete(ArticuloItem Item) {

            Item.IsDeleted = true;

            _RaiseEvent();

            return Item;
        }

        public ArticuloItem Restore(ArticuloItem Item) {
            Item.IsDeleted = false;

            _RaiseEvent();

            return Item;
        }

        public void Clear() {
            _LstArticulos.Clear();
            pnlCobranzaList.Controls.Clear();
            _RaiseEvent();
            this.pnlSubTotal.Visible = false;
        }

        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);

            foreach (ArticuloItem Item in this.Items) {
                //Cambiar el ancho del Item cuando el control cambie de tamano
                Item.Size = new Size(this.Size.Width, Item.Size.Height);
            }
            
        }

        private void _RaiseEvent() {

            if (OnListChange != null) {
                OnListChange.Invoke(this, new SubtotalInfo { Total = this.Items.SubTotal, Count = this.Items.Count });
            }

        }


    }
}
