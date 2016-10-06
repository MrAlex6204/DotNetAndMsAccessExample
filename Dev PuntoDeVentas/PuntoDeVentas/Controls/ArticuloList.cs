﻿using System;
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

        public delegate void OnChangeHandler (object sender, object e);
        public event OnChangeHandler OnListChange;
        //Creamos un evento de SelectedItemChange para notificar cuando el item seleccionado cambio
        public event ArticuloItemCollection.OnSelectedItemChangeHanlder OnSelectedItemChange;

        public struct SubtotalInfo {
            public int Count;
            public double Total;
        }
        
        public ArticuloList() {

            InitializeComponent();

            if (!this.DesignMode) {//Delete the dummy item
                this.Items.Clear();
                this.pnlCobranza.Controls.Clear();
            }

            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.ContainerControl, true);

            if (this.DesignMode) {
                this.BackColor = Color.FromArgb(64, 64, 64);
            }
            //ADJUNTAR EVENTO A LA LISTA CUANDO EL ITEM SELECCIONADO CAMBIO
            this.Items.OnSelectedItemChange += delegate (ArticuloItem e)
            {

                if (this.OnSelectedItemChange != null) {
                    //INVOCAR EVENTO CUANDO EL ITEM SELECCIONADO CAMBIO
                    this.OnSelectedItemChange.Invoke(e);
                }

            };

        

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
            pnlCobranza.ScrollControlIntoView(Item);
        }

        public ArticuloItem Add(ArticuloItem Item) {
                        
            this.Items.Add(Item);//Agregar el item a la lista de articulos

            this.Items.SelectedItem = Item;//Seleccionar el item

            Item.Size = new Size(this.Size.Width, Item.Size.Height);                       
                       

            pnlCobranza.Controls.Add(Item);//Agregar el container a la lista            

            pnlCobranza.ScrollControlIntoView(Item);

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
            pnlCobranza.Controls.Clear();

            _RaiseEvent();
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
