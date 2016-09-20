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

        public delegate void OnChangeHandler (object sender, object e);
        public event OnChangeHandler OnListChange;

        public struct SubtotalInfo {
            public int Count;
            public double Total;
        }


        public ArticuloList() {

            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.ContainerControl, true);

            if (this.DesignMode) {
                this.BackColor = Color.FromArgb(64, 64, 64);
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
            pnlCobranza.ScrollControlIntoView(Item);
        }

        public ArticuloItem Add(ArticuloItem Item) {

            Item.Dock = DockStyle.Top;
            this.Items.Add(Item);
            this.Items.SelectedItem = Item;
            pnlCobranza.Controls.Add(Item);            
            pnlCobranza.ScrollControlIntoView(Item);

            _RaiseEvent();        

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

        private void _RaiseEvent() {

            if (OnListChange != null) {
                OnListChange.Invoke(this, new SubtotalInfo { Total = this.Items.SubTotal, Count = this.Items.Count });
            }

        }
        

    }
}
