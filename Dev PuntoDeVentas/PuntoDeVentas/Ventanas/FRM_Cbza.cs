using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuntoDeVentas {

    public partial class FRM_Cbza : Form {

        public FRM_Cbza() {
            InitializeComponent();
        }

        #region  <DECLARACIONES>

        private bool isFullScreen = false;        
        private double Total = 0;

        private DataTable tblArticulosList = new DataTable();//Lista de Articulos registrados
        //Creamos una lista de articulos
        private ArticuloItemCollection LstArticulos = new ArticuloItemCollection(System.DbRepository.CajeroId);



        #endregion

        #region  <FUNCIONES ESPECIALES>


        private void AddArtItem(System.DbRepository.ArticuloInfo ArticuloItem, double Cantidad) {//Agrega un Articulo ala lista
            DataRow ArticuloRow = tblArticulosList.NewRow();
            ArticuloItem Item = new ArticuloItem(ArticuloItem, Cantidad);


            Item.Dock = DockStyle.Bottom;
            Item.SelectionColor = Color.Yellow;//Indicamos el color de seleccion

            //Agregamos el articulo a la lista y le indicamos el el elemento seleccionado
            LstArticulos.SelectedItem = LstArticulos.Add(Item);
            //Agregar el control item al panel de elementos
            pnlCobranza.Controls.Add(Item);
            pnlCobranza.VerticalScroll.Value = pnlCobranza.VerticalScroll.Maximum;

            ArticuloRow["ID"] = ArticuloItem.ID;
            ArticuloRow["DESC"] = ArticuloItem.DESCRIPCION;
            ArticuloRow["PRECIO"] = ArticuloItem.PRECIO;
            ArticuloRow["CANTIDAD"] = Cantidad;
            ArticuloRow["TOTAL"] = Item.Total;
            ArticuloRow["INVENTARIO"] = ArticuloItem.INV;

            //Agregamos el Item a la colleccion para poder calcular el Subtotal
            //y poder colorear el item agregado
            tblArticulosList.Rows.Add(ArticuloRow);//Agregamos el articulo ala lista
            txtCodigo.Focus();
        }


        private void ClearList() {

            pnlCobranza.Controls.Clear();
            LstArticulos.Clear();
        }

        private void BorrarCuenta()//Borramos todo lo de la cuenta abierta
        {            
            Total = 0;
            lblTotal.Text = Total.ToString("$ 0.00");
            ClearList();
            tblArticulosList.Rows.Clear();//Borramos la lista de articulos
            pnlStatus.Text = "";
        }

        private void GuardarTrans() {
            foreach (DataRow iRow in tblArticulosList.Rows) {//RECORREMOS TODOS LOS ARTICULOS DE LA LISTA

                //Guarda la lista de articulos en la base de datos
                System.DbRepository.RegistrarArticulo(iRow["ID"].ToString(), iRow["DESC"].ToString(), iRow["PRECIO"].ToString(), iRow["CANTIDAD"].ToString(), iRow["TOTAL"].ToString(), System.DbRepository.CajeroId);

                if (iRow["INVENTARIO"].ToString().ToUpper().Trim() == "TRUE") {//VALIDAMOS SI EL ARTICULO ES PARA REGISTRAR EN EL INVENTARIO
                    //REGISTRAMOS LA SALIDA DEL INVENTARIO DEL ARTICULO
                    System.DbRepository.InvRegistrarArticulo(iRow["ID"].ToString(), "0", iRow["CANTIDAD"].ToString(), System.DbRepository.CajeroId, "**VENTA**");
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
            lblFechaHra.Text = System.DateTime.Now.ToString("dddd,dd-MMMM-yyyy hh:mm:ss tt");
        }

        private void FRM_Cbza_Load(object sender, EventArgs e) {
            pnlStatus.Text = "";
            txtCodigo.Text = "";
            lblCajero.Text = System.DbRepository.Nombre.ToUpper();
            lblTitle.Text = System.DbRepository.GetConfig("EMPRESA");
            txtCodigo.Focus();
            lblTotal.Text = LstArticulos.SubTotal.ToString("$ 0.00");//Seteamos as Cero el total

            tblArticulosList.Columns.Add("ID");
            tblArticulosList.Columns.Add("DESC");
            tblArticulosList.Columns.Add("PRECIO");
            tblArticulosList.Columns.Add("CANTIDAD");
            tblArticulosList.Columns.Add("TOTAL");
            tblArticulosList.Columns.Add("INVENTARIO");

        }

        private void button2_Click(object sender, EventArgs e) {
            ClearList();

        }


        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                txtCodigo.Focus();
            }
        }
        
        private void FRM_Cbza_FormClosing(object sender, FormClosingEventArgs e) {
            if (Total > 0) {
                if (MessageBox.Show("Desea Salir de la Cbza?", "Desea salir ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    e.Cancel = false;
                } else {
                    e.Cancel = true;
                }
            }
        }

        #endregion


        #region Eventos del teclado

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
                    if (LstArticulos.SubTotal > 0) {//VALIDAMOS SI HAY COBRANZA ANTES DE MOSTRAR EL TOTAL 
                        FRM_Total wndTotal = new FRM_Total();
                        wndTotal.Total = LstArticulos.SubTotal;
                        //Lista de articulo para imprimir
                        System.DbRepository.ArticulosParaImprimir = tblArticulosList;

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
                    if (Total > 0) {
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

                case Keys.Up:
                    pnlCobranza.ScrollControlIntoView(LstArticulos.SelectPrev());
                    break;

                case Keys.Down:
                    pnlCobranza.ScrollControlIntoView(LstArticulos.SelectNext());
                    break;

                case (Keys.Control | Keys.Delete):

                    if (LstArticulos.Count > 0 && LstArticulos.SelectedItem != null) {

                        if (!LstArticulos.SelectedItem.IsDeleted) {//Solo si el articulo no ha sido eliminado

                            if (MessageBox.Show("Desea eliminar el articulo :" + LstArticulos.SelectedItem.Articulo.DESCRIPCION + " ?", "Eliminar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {
                                //Indicar que el Articulo seleccionado esta eliminado
                                LstArticulos.SelectedItem.IsDeleted = true;
                                //Actualizar el subtotal con el elemnto eliminado.
                                lblTotal.Text = LstArticulos.SubTotal.ToString("$ 0.00");
                            }

                        }

                    }

                    break;

                case (Keys.Control|Keys.Add):

                    if (LstArticulos.Count > 0 && LstArticulos.SelectedItem != null) {

                        if (LstArticulos.SelectedItem.IsDeleted) {//Solo si el articulo ya fue eliminado

                            if (MessageBox.Show("Volver agregar este articulo :" + LstArticulos.SelectedItem.Articulo.DESCRIPCION + " ?", "Volver agregar?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {
                                //Indicar que el Articulo seleccionado esta eliminado
                                LstArticulos.SelectedItem.IsDeleted = false;
                                //Actualizar el subtotal con el elemnto eliminado.
                                lblTotal.Text = LstArticulos.SubTotal.ToString("$ 0.00");
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
                            pnlStatus.Text = "Desc : " + Articulo.DESCRIPCION.ToUpper() + " $ " + Articulo.PRECIO + " Unidad :" + Articulo.UNIDAD;
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
                    System.DbRepository.ArticuloInfo ArticuloItem = System.DbRepository.GetArticuloInfo(txtCodigo.Text.Trim());

                    double Cantidad = (Convert.ToDouble(txtCantidad.Text));

                    //Si el Articulo Existe agregar a la lista
                    if (ArticuloItem.EXIST) {
                        //Agregar Articulo ala Lista en el Control
                        AddArtItem(ArticuloItem, Cantidad);

                        //Mostramos en pantalla el total acumulado
                        lblTotal.Text = LstArticulos.SubTotal.ToString("$ 0.00");
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


