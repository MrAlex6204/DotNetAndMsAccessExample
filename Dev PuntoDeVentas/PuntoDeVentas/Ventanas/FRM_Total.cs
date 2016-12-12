using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuntoDeVentas
{
    public partial class FRM_Total : Controls.BaseForm
    {
        public FRM_Total()
        {
            InitializeComponent();
            this._RenderDesign();
            this.Activate();
            this.txtPago.Focus();
            this.txtPago.Select();
        }

        private double _SubTotal = 0;//Variable para guardar el total
        private double _Total = 0;
        private double _Efectivo = 0;
        private bool _Cancelled = true;

        public double Total
        {//Proiedad para establecer el total
            set
            {
                _SubTotal = value;
                _Total = value;
                lblTotal.Text = Functions.ToCurrency(_SubTotal);
            }
        }

        public bool IsCancelled
        {
            get
            {
                return _Cancelled;
            }
        }
        
        private void FRM_Total_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }

        private void FRM_Total_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FRM_Total_Load(object sender, EventArgs e)
        {
            txtPago.Focus();
            lblEfectivo.Text = Functions.ToCurrency(0.00);
            this._RenderDesign();
        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {//Si  preciono enter
                if (Functions.IsNumber(txtPago.Text))
                {
                    _SubTotal = _SubTotal - Functions.ToNumber(txtPago.Text);//Descontamos al total el efectivo
                    _Efectivo += Functions.ToNumber(txtPago.Text);//sumamos el efectivo recibido
                    lblEfectivo.Text = Functions.ToCurrency(_Efectivo);
                    lblTotal.Text = Functions.ToCurrency(_SubTotal);

                    if (_SubTotal <= 0)
                    {//si total es menor o igual a cero
                        _Cancelled = false;
                        this.Hide();//Ocultamos el formulario

                        //Mostramos la pantalla de Cambio
                        Functions.MostrarCambio("CAMBIO " + Functions.ToCurrency(Math.Abs(_SubTotal)), Functions.ToCurrency(_Total), Functions.ToCurrency(_Efectivo), Functions.ToCurrency(Math.Abs(_SubTotal)), this);
                        this.Close();//Cerramos el formulario 
                    }
                    txtPago.Text = "";


                }
                else
                {
                    txtPago.Text = "";
                    txtPago.Focus();

                }

            }
        }


    }
}