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



    [DefaultEvent("OnChange")]
    public partial class ArticuloList : UserControl {

        private System.ArticuloItemCollection _LstArticulos = new System.ArticuloItemCollection();
        public delegate void OnChangeHandler (object sende, object e);

        public OnChangeHandler OnChange;
        
        public ArticuloList() {

            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.ContainerControl, true);

        }


        public ArticuloItemCollection Articulos {

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
            this.Articulos.Add(Item);
            this.Articulos.SelectedItem = Item;
            pnlCobranza.Controls.Add(Item);            
            pnlCobranza.ScrollControlIntoView(Item);


            if( OnChange != null){
                OnChange.Invoke(this, this.Articulos.SubTotal);
            }

            return Item;
        }

        public ArticuloItem Remove(ArticuloItem Item) {

            Item.IsDeleted = true;


            if (OnChange != null) {
                OnChange.Invoke(this, this.Articulos.SubTotal);
            }

            return Item;
        }

        public void Clear() {
            _LstArticulos.Clear();

            if (OnChange != null) {
                OnChange.Invoke(this, this.Articulos.SubTotal);
            }
        }
        

    }
}
