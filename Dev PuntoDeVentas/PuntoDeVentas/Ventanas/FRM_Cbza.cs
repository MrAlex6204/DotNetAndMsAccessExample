using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuntoDeVentas {

    public partial class FRM_Cbza : Controls.BaseForm {

        public FRM_Cbza() {
            InitializeComponent();         
        }

        #region  <DECLARACIONES>
        private bool isFullScreen = false;        
        
        #endregion

        #region  <FUNCIONES ESPECIALES>
        
        private void BorrarCuenta()//Borramos todo lo de la cuenta abierta
        {   
            pnlStatus.Text = "";
            this.LstArticulos.Clear();           
        }

        private void GuardarTrans() {
            foreach (ArticuloItem Item in this.LstArticulos.Items) {//RECORREMOS TODOS LOS ARTICULOS DE LA LISTA

                //Guarda la lista de articulos en la base de datos
                System.DbRepository.RegistrarArticulo(
                                                        Item.Articulo.ID, 
                                                        Item.Articulo.DESCRIPCION, 
                                                        Item.Articulo.PRECIO, 
                                                        Item.Cantidad.ToString(), 
                                                        Item.Total.ToString(), 
                                                        System.DbRepository.CajeroId
                                                     );

                if (Item.Articulo.INV == "TRUE") {//VALIDAMOS SI EL ARTICULO ES PARA REGISTRAR EN EL INVENTARIO
                    //REGISTRAMOS LA SALIDA DEL INVENTARIO DEL ARTICULO
                    System.DbRepository.InvRegistrarArticulo(
                                                                Item.Articulo.ID, "0", 
                                                                Item.Cantidad.ToString(), 
                                                                System.DbRepository.CajeroId, 
                                                                "**VENTA**"
                                                             );

                }

            }
        }

        private void FullScreen() {
            
            if (isFullScreen) {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                this.WindowState = FormWindowState.Normal;
            } else {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }

            isFullScreen = !isFullScreen;

        }

        #endregion

        #region  <EVENTOS DEL FORMULARIO>

        private void tmrFechayHra_Tick(object sender, EventArgs e) {
            //Mostrar fecha y Hra
            lblFechaHra.Text = System.DateTime.Now.ToString("dddd,dd-MMMM-yyyy hh:mm tt");
        }

        private void FRM_Cbza_Load(object sender, EventArgs e) {

            pnlStatus.Text = "";
            txtCodigo.Text = "";
            lblCajero.Text = System.DbRepository.Nombre.ToUpper();
            lblTitle.Text = System.DbRepository.GetConfig("EMPRESA");
            txtCodigo.Focus();
            this.LstArticulos.Clear();
            

        }
                
        private void FRM_Cbza_FormClosing(object sender, FormClosingEventArgs e) {
            if (this.LstArticulos.Items.SubTotal > 0) {
                if (MessageBox.Show("Desea Salir de la Cbza?", "Desea salir ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    e.Cancel = false;
                } else {
                    e.Cancel = true;
                }
            }
        }

        private void LstArticulos_OnChange(object sende, object e) {
            //Actualizar el total en pantalla
            lblTotal.Text = String.Format("$ {0}", ((ArticuloList.SubtotalInfo)e).Total.ToString("0.00"));
            lblArticuloCount.Text = String.Format("CANT. ARTICULOS : {0}", ((ArticuloList.SubtotalInfo)e).Count.ToString("00"));
        }

        #endregion

        #region EVENTOS DEL TECLADO

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                txtCodigo.Focus();
            }
        }

        private void Wnd_KeyDown(object sender, KeyEventArgs e) {

            switch (e.KeyData)//Seleccionar el la funcion de acuerdo ala tecla presionada.
            {
                case Keys.Escape:
                    FRM_ConsultarArticulos wndBuscarArt = new FRM_ConsultarArticulos();
                    wndBuscarArt.ShowDialog(this);
                    if (wndBuscarArt.ArticuloId.Trim() != "") {//Si el articulo id es diferente a vacion
                        txtCodigo.Text = wndBuscarArt.ArticuloId;//le pasamos el textbox codigo el id del articulo
                        txtCodigo.Focus();
                    }
                    break;
                case Keys.F1://F1
                    if (this.LstArticulos.Items.SubTotal > 0) {//VALIDAMOS SI HAY COBRANZA ANTES DE MOSTRAR EL TOTAL 
                        FRM_Total wndTotal = new FRM_Total();
                        wndTotal.Total = this.LstArticulos.Items.SubTotal;
                        //Lista de articulo para imprimir
                        System.DbRepository.ArticulosParaImprimir = this.LstArticulos.Items;

                        wndTotal.ShowDialog(this);

                        if (wndTotal.IsCancelled == false) {//si la transaccion no fue borrada
                            GuardarTrans();//Guardamos la transaccion en la Bd.
                            BorrarCuenta();
                        }

                    } else {
                        Functions.Message("NO HAY ARTICULOS POR COBRAR!");
                    }

                    break;
                case Keys.F2://F2
                    FRM_AgregarArticulo wndAgregarArt = new FRM_AgregarArticulo();
                    wndAgregarArt.ShowDialog(this);
                    break;
                case Keys.F3://F3
                    FRM_CorteDeCaja wndCorteDeCaja = new FRM_CorteDeCaja();
                    wndCorteDeCaja.ShowDialog(this);
                    break;
                case Keys.F4://F4
                    this.Close();
                    break;
                case Keys.F5://F5
                    txtCantidad.Focus();
                    break;
                case Keys.F6://F6
                    txtCodigo.Focus();
                    break;
                case Keys.F7://F7
                    if (this.LstArticulos.Items.SubTotal > 0) {
                        if (MessageBox.Show("Desea cancelar la transaccion?", "Cancelar Transaccion?", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                            BorrarCuenta();
                            Functions.Message("TRANSACCION CANCELADA!");
                        }
                    }
                    break;
                case Keys.F8:
                    FRM_VentaDelDia wndVentaDelDia = new FRM_VentaDelDia();
                    wndVentaDelDia.ShowDialog(this);
                    break;

                case Keys.F11:
                    FullScreen();
                    break;

                case Keys.Up://MOVER SELECCION HACIA ARRIBA
                    var PrevSelected = this.LstArticulos.Items.SelectPrev();
                    this.LstArticulos.ScrollIntoView(PrevSelected);

                    break;

                case Keys.Down://MOVER SELECCION HACIA ABAJO
                    var NextSelected = this.LstArticulos.Items.SelectNext();
                    this.LstArticulos.ScrollIntoView(NextSelected);
                    
                    break;

                case (Keys.Control | Keys.Delete):

                    if (this.LstArticulos.Items.Count > 0 && this.LstArticulos.Items.SelectedItem != null) {

                        if (!this.LstArticulos.Items.SelectedItem.IsDeleted) {//Solo si el articulo no ha sido eliminado

                            if (MessageBox.Show("Desea eliminar el articulo :" + this.LstArticulos.Items.SelectedItem.Articulo.DESCRIPCION + " ?", "Eliminar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {
                                //Indicar que el Articulo seleccionado esta eliminado
                                this.LstArticulos.Delete(this.LstArticulos.Items.SelectedItem);                                
                                
                            }

                        }

                    }

                    break;

                case (Keys.Control|Keys.Add):

                    if (this.LstArticulos.Items.Count > 0 && this.LstArticulos.Items.SelectedItem != null) {

                        if (this.LstArticulos.Items.SelectedItem.IsDeleted) {//Solo si el articulo ya fue eliminado

                            if (MessageBox.Show("Volver agregar este articulo :" + this.LstArticulos.Items.SelectedItem.Articulo.DESCRIPCION + " ?", "Volver agregar?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {
                                //Indicar que el Articulo seleccionado esta eliminado
                                this.LstArticulos.Restore(this.LstArticulos.Items.SelectedItem);                                
                                
                            }

                        }
                    }

                    break;

                case (Keys.Control | Keys.Up)://Incrementar la cantidad del articulo

                    int IncrementarCantidad = 0;

                    int.TryParse(txtCantidad.Text.Trim(), out IncrementarCantidad);

                    IncrementarCantidad++;

                    txtCantidad.Text = IncrementarCantidad.ToString();

                    break;

                case (Keys.Control | Keys.Down)://Decrementar la cantidad del articulo

                    int DecrementarCantidad= 0;

                    int.TryParse(txtCantidad.Text.Trim(), out DecrementarCantidad);

                    DecrementarCantidad--;

                    txtCantidad.Text = DecrementarCantidad.ToString();

                    break;

                case (Keys.Control | Keys.Tab):

                    if (txtCodigo.Text.Length > 0) {

                        var Articulo = System.DbRepository.GetArticuloInfo(txtCodigo.Text.Trim());

                        if (Articulo.EXIST) {                            
                            var Cantidad = double.Parse(txtCantidad.Text);
                            pnlStatus.Text = Articulo.ToString(Cantidad);
                        } else {
                            pnlStatus.Text = "** NO EXISTE **";
                        }

                    }

                    break;

            }

        }
        
        private void ArticuloCode_KeyDown(object sender, KeyEventArgs e) {

            switch (e.KeyCode) { 
            
                case Keys.Enter:

                    //Declaramos una variable tipo ArticuloInfo y 
                    //obtenemos la informacion del articulo pasando le el codigo
                    System.DbRepository.ArticuloInfo Articulo = System.DbRepository.GetArticuloInfo(txtCodigo.Text.Trim());
                    
                    //Si el Articulo Existe agregar a la lista
                    if (Articulo.EXIST) {
                        double Cantidad = (Convert.ToDouble(txtCantidad.Text));
                        ArticuloItem Item = new ArticuloItem(Articulo, Cantidad); 
                        
                        //Agregamos el Item a la lista
                        LstArticulos.Add(Item);
                        
                        txtCodigo.Focus();
                        txtCodigo.Text = "";
                        txtCantidad.Text = "1";



                    } else { //Si el articulo no existe

                        Functions.Message("NO EXISTE EL ARTICULO!");
                    }


                    break;

            }

        }

        #endregion

        

              


    }
}


