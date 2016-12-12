using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVentas.Controls {

    [DefaultEvent("OnTransactionEnd")]
    public partial class SubTotalPanel : UserControl {


        public delegate void OnTransactionEndHandler(string Total, string Pago, string Cambio);
        public OnTransactionEndHandler OnTransactionEnd;

        private double _SubTotal = 0;//Variable para guardar el total
        private double _Total = 0;
        private double _Efectivo = 0;


        public SubTotalPanel() {
            InitializeComponent();
            _RenderizeText();
        }

        public System.ArticuloItemCollection Items {
            set {
                //Indicamo el SubTotal a cobrar y la cantidad de articulos vendidos
                Clear();
                lblArticuloCount.Text = "CANT. ARTICULOS : " + value.Count.ToString("00");
                _SubTotal = value.SubTotal;
                _RenderizeText();

            }
        }

        private void _RenderizeText() {
            lblSubTotal.Text = Functions.ToCurrency(_SubTotal);
            lblEfectivo.Text = Functions.ToCurrency(_Efectivo);
        }

        public void Clear() {
            _SubTotal = 0;//Variable para guardar el total
            _Total = 0;
            _Efectivo = 0;
            txtPago.Text = string.Empty;
            lblArticuloCount.Text = "CANT. ARTICULOS : 00";
            _RenderizeText();
        }
        
        private void _PagoKeyPress(object sender, KeyPressEventArgs e) {


            if (e.KeyChar == 13) {//SI  PRECIONO ENTER
                if (Functions.IsNumber(txtPago.Text)) {
                    _SubTotal = _SubTotal - Functions.ToNumber(txtPago.Text);//Descontamos al total el efectivo
                    _Efectivo += Functions.ToNumber(txtPago.Text);//sumamos el efectivo recibido

                    if (_SubTotal <= 0) {//si total es menor o igual a cero


                        //Mostramos la pantalla de Cambio

                        if (OnTransactionEnd != null) {
                            //Ejecutar Evento para notificar que la transaccion termino
                            OnTransactionEnd.Invoke(
                                                    Functions.ToCurrency(_Total),
                                                    Functions.ToCurrency(_Efectivo),
                                                    Functions.ToCurrency(Math.Abs(_SubTotal))
                                                   );

                        }
                        
                        Clear();

                    } else {

                        txtPago.Text = "";
                        _RenderizeText();

                    }


                } else {
                    txtPago.Text = "";
                    txtPago.Focus();

                }

            }

        }


    }

}
