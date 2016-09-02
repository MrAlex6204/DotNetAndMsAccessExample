using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace System {

    public partial class ArticuloItem : UserControl {

        private bool _bIsSelected = false;
        private Drawing.Color _SelectionColor;
        private int _Position = 0;
        private double _Cantidad = 0;
        private System.DbRepository.ArticuloInfo _Articulo;
        private bool _bIsDeleted = false;
        private Drawing.Color _DefaultColor = Drawing.Color.WhiteSmoke;

        public ArticuloItem(System.DbRepository.ArticuloInfo ArticuloItem, double Cantidad) {
            InitializeComponent();
            _DefaultColor = this.BackColor;
            //Llenamos la informacion del articulo
            this.Update(ArticuloItem, Cantidad);
        }

       
        protected ArticuloItem() {
            InitializeComponent();
            _DefaultColor = this.BackColor;
        }

        public bool IsSelected {
            get {
                return _bIsSelected;
            }
            set {

                if (value) {
                    if (this.IsDeleted) {//Color de seleccion si el elemento esta marcado como eliminado
                        this.BackColor = Color.Maroon;
                    } else {
                        this.BackColor = _SelectionColor;
                    }
                } else {
                    if (this.IsDeleted) {
                        this.BackColor = Color.Tomato;
                    } else {
                        this.BackColor = _DefaultColor;
                    }
                }

                _bIsSelected = value;
                this.Update();
            }
        }

        [Category("Design")]
        [Browsable(true)]
        public Drawing.Color DefaultBgColor {//Establecer el color de fondo por defecto
            get {
                return _DefaultColor;
            }
            set {
                _DefaultColor = value;
            }
        }

        public Drawing.Color SelectionColor {
            get {
                return _SelectionColor;
            }
            set {
                _SelectionColor = value;
            }
        }

        public int Position {
            get {//Guardamos la posicion que tiene en la lista despues que fue insertado
                return _Position;
            }
            set {
                _Position = value;
            }
        }

        public double Cantidad {
            get {
                return _Cantidad;
            }
        }

        public System.DbRepository.ArticuloInfo Articulo {

            get {
                return _Articulo;
            }
        }

        public bool IsDeleted {
            get {
                return _bIsDeleted;
            }
            set {

                if (value) {
                    this.BackColor = Color.Tomato;
                } else {
                    if (this.IsSelected) {
                        //Si el Item esta seleccionado cambiar el color
                        this.BackColor = _SelectionColor;
                    } else {
                        this.BackColor = _DefaultColor;
                    }
                }

                _bIsDeleted = value;

            }
        }

        public double Total {
            get {//Calcular el total en base precio y cantidad
                if (_Articulo.EXIST) {
                    return _Cantidad * double.Parse(_Articulo.PRECIO);
                } else {
                    return 0;
                }
            }
        }

        //Con esta funcion actualizamos la informacion del articulo
        public void Update(System.DbRepository.ArticuloInfo ArticuloItem, double Cantidad) {

            this._Cantidad = Cantidad;
            this._Articulo = ArticuloItem;

            lblArticulo.Text = _Articulo.DESCRIPCION;
            lblPrecio.Text = Double.Parse(_Articulo.PRECIO).ToString("$ 0.00");
            lblCodigo.Text = _Articulo.ID;
            lblTotal.Text = this.Total.ToString("$ 0.00");
            lblCantidad.Text = this.Cantidad.ToString("0.00 " + ArticuloItem.UNIDAD);

        }





    }
}
