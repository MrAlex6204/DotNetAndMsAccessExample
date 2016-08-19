<<<<<<< HEAD
﻿using System;
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
        private int TotalArticulos = 0;
        private double Total = 0;

        private DataTable tblArticulosList = new DataTable();//Lista de Articulos registrados
        //Creamos una lista de articulos
        private ArticulosCollection LstArticulos = new ArticulosCollection(System.PuntoDeVentas.CajeroId);



        #endregion

        #region  <FUNCIONES ESPECIALES>


        private void AddArtItem(System.PuntoDeVentas.ArticuloInfo ArticuloItem, double Cantidad) {//Agrega un Articulo ala lista
            DataRow ArticuloRow = tblArticulosList.NewRow();
            CTRL_ArticuloItem Item = new CTRL_ArticuloItem(ArticuloItem, Cantidad);


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
            TotalArticulos = 0;
            Total = 0;
            lblTotal.Text = Total.ToString("$ 0.00");
            ClearList();
            tblArticulosList.Rows.Clear();//Borramos la lista de articulos

        }

        private void GuardarTrans() {
            foreach (DataRow iRow in tblArticulosList.Rows) {//RECORREMOS TODOS LOS ARTICULOS DE LA LISTA

                //Guarda la lista de articulos en la base de datos
                System.PuntoDeVentas.RegistrarArticulo(iRow["ID"].ToString(), iRow["DESC"].ToString(), iRow["PRECIO"].ToString(), iRow["CANTIDAD"].ToString(), iRow["TOTAL"].ToString(), System.PuntoDeVentas.CajeroId);

                if (iRow["INVENTARIO"].ToString().ToUpper().Trim() == "TRUE") {//VALIDAMOS SI EL ARTICULO ES PARA REGISTRAR EN EL INVENTARIO
                    //REGISTRAMOS LA SALIDA DEL INVENTARIO DEL ARTICULO
                    System.PuntoDeVentas.InvRegistrarArticulo(iRow["ID"].ToString(), "0", iRow["CANTIDAD"].ToString(), System.PuntoDeVentas.CajeroId, "**VENTA**");
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
            txtCodigo.Text = "";
            lblCajero.Text = System.PuntoDeVentas.Nombre.ToUpper();
            lblTitle.Text = System.PuntoDeVentas.GetConfig("EMPRESA");
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

        private void FRM_Cbza_KeyDown(object sender, KeyEventArgs e) {

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
                    if (LstArticulos.SubTotal > 0)//VALIDAMOS SI HAY COBRANZA ANTES DE MOSTRAR EL TOTAL
                    {
                        FRM_Total wndTotal = new FRM_Total();
                        wndTotal.Total = LstArticulos.SubTotal;
                        //Lista de articulo para imprimir
                        System.PuntoDeVentas.ArticulosParaImprimir = tblArticulosList;

                        wndTotal.ShowDialog(this);
                        if (wndTotal.IsCancelled == false) {//si la transaccion no fue borrada
                            GuardarTrans();//Guardamos la transaccion en la Bd.
                            BorrarCuenta();
                        }

                    } else {
                        Funciones.Message("NO HAY ARTICULOS POR COBRAR!");
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
                            Funciones.Message("TRANSACCION CANCELADA!");
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

                case Keys.Delete:

                    if (!LstArticulos.SelectedItem.IsDeleted) {//Solo si el articulo no ha sido eliminado

                        if (MessageBox.Show("Desea eliminar el articulo :" + LstArticulos.SelectedItem.Articulo.DESCRIPCION + " ?", "Eliminar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {
                            //Indicar que el Articulo seleccionado esta eliminado
                            LstArticulos.SelectedItem.IsDeleted = true;
                            //Actualizar el subtotal con el elemnto eliminado.
                            lblTotal.Text = LstArticulos.SubTotal.ToString("$ 0.00");
                        }

                    }

                    break;

                case Keys.Add:

                    if (LstArticulos.SelectedItem.IsDeleted) {//Solo si el articulo ya fue eliminado

                        if (MessageBox.Show("Volver agregar este articulo :" + LstArticulos.SelectedItem.Articulo.DESCRIPCION + " ?", "Volver agregar?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {
                            //Indicar que el Articulo seleccionado esta eliminado
                            LstArticulos.SelectedItem.IsDeleted = false;
                            //Actualizar el subtotal con el elemnto eliminado.
                            lblTotal.Text = LstArticulos.SubTotal.ToString("$ 0.00");
                        }

                    }
                                        
                    break;
                    

            }

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                txtCodigo.Focus();
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                //Declaramos una variable tipo ArticuloInfo y 
                //obtenemos la informacion del articulo pasando le el codigo
                System.PuntoDeVentas.ArticuloInfo ArticuloItem = System.PuntoDeVentas.GetArticuloInfo(txtCodigo.Text.Trim());

                double Cantidad = (Convert.ToDouble(txtCantidad.Text));

                //Si el Articulo Existe agregar a la lista
                if (ArticuloItem.EXIST) {
                    //Autoincrementamos el numero de articulos
                    TotalArticulos++;

                    //Agregar Articulo ala Lista en el Control
                    AddArtItem(ArticuloItem, Cantidad);

                    //Mostramos en pantalla el total acumulado
                    lblTotal.Text = LstArticulos.SubTotal.ToString("$ 0.00");
                    txtCodigo.Focus();
                    txtCodigo.Text = "";

                } else { //Si el articulo no existe

                    Funciones.Message("NO EXISTE EL ARTICULO!");
                }



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


    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuntoDeVentas
{
    public partial class FRM_Cbza : Form
    {
        public FRM_Cbza()
        {
            InitializeComponent();
        }

        #region  <DECLARACIONES>

        int TotalArticulos = 0;
        double Total = 0;

        DataTable tblArticulosList = new DataTable();//Lista de Articulos registrados

        


        #endregion

        #region  <FUNCIONES ESPECIALES>

        int CtrlNo = 0;//Nombre Del Control

        private void AddArtItem(string No, string Articulo, string Codigo, double Cantidad, string Unidad, double Precio, double Total,string Inventario)
        {//Agrega un Articulo ala lista
            GroupBox pnlItem = getItemArt(); //Obtenemos el Group box del diseño;   
            DataRow ArticuloRow = tblArticulosList.NewRow();
            string ControlName = "";
            pnlItem.Width = pnlCobranza.Width - 30;//Ajustamos el Ancho del control que vamos agregar
            pnlItem.Visible = true;
            ControlName = pnlItem.Name;
            pnlItem.Name = ControlName + CtrlNo.ToString();

            if (CtrlNo > 0)
            {  //Si es el segundo o mas de uno en la lista
                pnlItem.BackColor = Color.Yellow;//sombreamos de amarillo al actual
                string CtrlAnterior = ControlName + (CtrlNo - 1).ToString();//Nombre del Control Anterior

                foreach (Control iControl in pnlCobranza.Controls) {//Buscamos el control anterior y lo sombreamos de blanco
                    if (iControl.Name == CtrlAnterior) {
                        iControl.BackColor = Color.White;
                    }

                }

            }
            else { 
            //Si es el primero de la lista
                pnlItem.BackColor = Color.Yellow;
            }


            foreach (Control i in pnlItem.Controls)//Recorremos todos los controles del GroupBox para Encontar el nombre del control
            {

                switch (i.Name)
                {

                    case "Articulo":
                        i.Text = No + "-" + Articulo;
                        i.Name = i.Name + CtrlNo.ToString();
                        break;
                    case "Cantidad":
                        i.Text = Cantidad.ToString("0.00");
                        i.Name = i.Name + CtrlNo.ToString();
                        break;

                    case "Precio":
                        i.Text = Precio.ToString("$ 0.00") + "  " + Unidad.Trim().ToLower();
                        i.Name = i.Name + CtrlNo.ToString();
                        break;

                    case "Total":
                        i.Text = "$ " + Total;
                        i.Name = i.Name + CtrlNo.ToString();
                        break;
                    case "Codigo":
                        i.Text = Codigo.ToUpper();
                        i.Name = i.Name + CtrlNo.ToString();
                        break;



                    default:
                        i.Name = i.Name + CtrlNo.ToString();
                        break;
                }
            }

            pnlCobranza.Controls.Add(pnlItem);
            pnlCobranza.ScrollControlIntoView(pnlItem);

            ArticuloRow["ID"] = Codigo;
            ArticuloRow["DESC"] = Articulo.ToUpper();
            ArticuloRow["PRECIO"] = Precio;
            ArticuloRow["CANTIDAD"] = Cantidad;
            ArticuloRow["TOTAL"] = Total;
            ArticuloRow["INVENTARIO"] = Inventario.ToUpper().Trim();

            tblArticulosList.Rows.Add(ArticuloRow);//Agregamos el articulo ala lista
            CtrlNo++;
        }

        private GroupBox getItemArt()
        {
            //Creamos un GroupBox Dinamicamente y retornamos el mismo groupbox creado

            System.Windows.Forms.Label Articulo;
            System.Windows.Forms.Label Cantidad;
            System.Windows.Forms.Label Precio;
            System.Windows.Forms.Label por;
            System.Windows.Forms.Label iTotal;
            System.Windows.Forms.Label igual;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label lblCodeLabel;
            System.Windows.Forms.Label Codigo;
            System.Windows.Forms.GroupBox grpArtItem;

            Articulo = new System.Windows.Forms.Label();
            Cantidad = new System.Windows.Forms.Label();
            Precio = new System.Windows.Forms.Label();
            por = new System.Windows.Forms.Label();
            iTotal = new System.Windows.Forms.Label();
            igual = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblCodeLabel = new System.Windows.Forms.Label();
            Codigo = new System.Windows.Forms.Label();
            grpArtItem = new System.Windows.Forms.GroupBox();

            // 
            // Articulo
            // 
            Articulo.AutoSize = true;
            Articulo.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Articulo.Location = new System.Drawing.Point(6, 10);
            Articulo.Name = "Articulo";
            Articulo.Size = new System.Drawing.Size(160, 33);
            Articulo.TabIndex = 0;
            Articulo.Text = "[ARTICULO]";
            Articulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cantidad
            // 
            Cantidad.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Cantidad.Location = new System.Drawing.Point(78, 46);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new System.Drawing.Size(129, 23);
            Cantidad.TabIndex = 1;
            Cantidad.Text = "[CANTIDAD]";
            Cantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Precio
            // 
            Precio.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Precio.Location = new System.Drawing.Point(225, 46);
            Precio.Name = "Precio";
            Precio.Size = new System.Drawing.Size(130, 23);
            Precio.TabIndex = 2;
            Precio.Text = "[PRECIO]";
            Precio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // por
            // 
            por.AutoSize = true;
            por.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            por.Location = new System.Drawing.Point(207, 48);
            por.Name = "por";
            por.Size = new System.Drawing.Size(18, 19);
            por.TabIndex = 3;
            por.Text = "@";
            por.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iTotal
            // 
            iTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iTotal.Location = new System.Drawing.Point(373, 46);
            iTotal.Name = "Total";
            iTotal.Size = new System.Drawing.Size(127, 23);
            iTotal.TabIndex = 4;
            iTotal.Text = "[TOTAL]";
            iTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // igual
            // 
            igual.AutoSize = true;
            igual.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            igual.Location = new System.Drawing.Point(355, 48);
            igual.Name = "igual";
            igual.Size = new System.Drawing.Size(18, 19);
            igual.TabIndex = 5;
            igual.Text = "=";
            igual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(6, 46);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 23);
            label4.TabIndex = 7;
            label4.Text = "Cant.:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCodeLabel
            // 
            lblCodeLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCodeLabel.Location = new System.Drawing.Point(500, 46);
            lblCodeLabel.Name = "lblCodeLabel";
            lblCodeLabel.Size = new System.Drawing.Size(91, 23);
            lblCodeLabel.TabIndex = 8;
            lblCodeLabel.Text = "Codigo :";
            lblCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Codigo
            // 
            Codigo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Codigo.Location = new System.Drawing.Point(591, 46);
            Codigo.Name = "Codigo";
            Codigo.Size = new System.Drawing.Size(200, 23);
            Codigo.TabIndex = 9;
            Codigo.Text = "[CODIGO]";
            Codigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpArtItem
            // 
            grpArtItem.Controls.Add(Codigo);
            grpArtItem.Controls.Add(lblCodeLabel);
            grpArtItem.Controls.Add(label4);
            grpArtItem.Controls.Add(igual);
            grpArtItem.Controls.Add(iTotal);
            grpArtItem.Controls.Add(por);
            grpArtItem.Controls.Add(Precio);
            grpArtItem.Controls.Add(Cantidad);
            grpArtItem.Controls.Add(Articulo);
            grpArtItem.Name = "grpArtItem";
            grpArtItem.Size = new System.Drawing.Size(1050, 76);
            grpArtItem.TabIndex = 0;
            return grpArtItem;



        }

        private void ClearList()
        {
            CtrlNo = 0;
            pnlCobranza.Controls.Clear();
        }

        private void BorrarCuenta()//Borramos todo lo de la cuenta abierta
        {
            TotalArticulos = 0;
            Total = 0;
            lblTotal.Text = Total.ToString("$ 0.00");
            ClearList();
            tblArticulosList.Rows.Clear();//Borramos la lista de articulos
            CtrlNo = 0;
        }

        private void GuardarTrans() {
            foreach (DataRow iRow in tblArticulosList.Rows) {//RECORREMOS TODOS LOS ARTICULOS DE LA LISTA

                //Guarda la lista de articulos en la base de datos
                System.PuntoDeVentas.RegistrarArticulo(iRow["ID"].ToString(), iRow["DESC"].ToString(), iRow["PRECIO"].ToString(), iRow["CANTIDAD"].ToString(),iRow["TOTAL"].ToString(), System.PuntoDeVentas.CajeroId);

                if (iRow["INVENTARIO"].ToString().ToUpper().Trim() == "TRUE") {//VALIDAMOS SI EL ARTICULO ES PARA REGISTRAR EN EL INVENTARIO
                    //REGISTRAMOS LA SALIDA DEL INVENTARIO DEL ARTICULO
                    System.PuntoDeVentas.InvRegistrarArticulo(iRow["ID"].ToString(), "0", iRow["CANTIDAD"].ToString(), System.PuntoDeVentas.CajeroId, "**VENTA**");
                }

            }
        }

        #endregion

        #region  <EVENTOS DEL FORMULARIO>

        private void tmrFechayHra_Tick(object sender, EventArgs e)
        {
            //Mostrar fecha y Hra
            lblFechaHra.Text = System.DateTime.Now.ToString("dddd,dd-MMMM-yyyy hh:mm:ss tt");
        }

        private void FRM_Cbza_Load(object sender, EventArgs e)
        {
            lblCajero.Text = System.PuntoDeVentas.Nombre.ToUpper();
            lblTitle.Text = System.PuntoDeVentas.GetConfig("EMPRESA");
            txtCodigo.Focus();
            lblTotal.Text = (0).ToString("$ 0.00");//Seteamos as Cero el total

            tblArticulosList.Columns.Add("ID");
            tblArticulosList.Columns.Add("DESC");
            tblArticulosList.Columns.Add("PRECIO");
            tblArticulosList.Columns.Add("CANTIDAD");
            tblArticulosList.Columns.Add("TOTAL");
            tblArticulosList.Columns.Add("INVENTARIO");           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearList();

        }

        private void FRM_Cbza_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyValue)//Seleccionar el la funcion de acuerdo ala tecla presionada.
            {
                case 27:
                    FRM_ConsultarArticulos wndBuscarArt = new FRM_ConsultarArticulos();
                    wndBuscarArt.ShowDialog(this);
                    if(wndBuscarArt.ArticuloId.Trim() != ""){//Si el articulo id es diferente a vacion
                        txtCodigo.Text = wndBuscarArt.ArticuloId;//le pasamos el textbox codigo el id del articulo
                        txtCodigo.Focus();
                    }
                    break;
                case 112://F1
                    if (Total > 0)//VALIDAMOS SI HAY COBRANZA ANTES DE MOSTRAR EL TOTAL
                    {
                        FRM_Total wndTotal = new FRM_Total();
                        wndTotal.Total = Total;
                        //Lista de articulo para imprimir
                        System.PuntoDeVentas.ArticulosParaImprimir = tblArticulosList;
                        wndTotal.ShowDialog(this);
                        if (wndTotal.IsCancelled ==false) {//si la transaccion no fue borrada
                            GuardarTrans();//Guardamos la transaccion en la Bd.
                            BorrarCuenta();
                        }

                    }
                    else
                    {
                        Funciones.Message("NO HAY ARTICULOS POR COBRAR!");
                    }

                    break;
                case 113://F2
                    FRM_AgregarArticulo wndAgregarArt = new FRM_AgregarArticulo();
                    wndAgregarArt.ShowDialog(this);
                    break;
                case 114://F3
                    FRM_CorteDeCaja wndCorteDeCaja = new FRM_CorteDeCaja();
                    wndCorteDeCaja.ShowDialog(this);
                    break;
                case 115://F4
                    this.Close();
                    break;
                case 116://F5
                    txtCantidad.Focus();
                    break;
                case 117://F6
                    txtCodigo.Focus();
                    break;
                case 118://F7
                    if (Total > 0)
                    {
                        if (MessageBox.Show("Desea cancelar la transaccion?", "Cancelar Transaccion?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            BorrarCuenta();
                            Funciones.Message("TRANSACCION CANCELADA!");
                        }
                    }
                    break;
                case 119:
                    FRM_VentaDelDia wndVentaDelDia = new FRM_VentaDelDia();
                    wndVentaDelDia.ShowDialog(this);
                    break;


            }

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtCodigo.Focus();
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //Declaramos una variable tipo ArticuloInfo
                System.PuntoDeVentas.ArticuloInfo Articulo = new System.PuntoDeVentas.ArticuloInfo();
                //Obtenemos la informacion del articulo pasando le el codigo
                Articulo = System.PuntoDeVentas.GetArticuloInfo(txtCodigo.Text.Trim());

                double Cantidad = (Convert.ToDouble(txtCantidad.Text));
                double Precio = Convert.ToDouble(Articulo.PRECIO);

                //Si el Articulo Existe agregar a la lista
                if (Articulo.EXIST)
                {
                    //Autoincrementamos el numero de articulos
                    TotalArticulos++;
                    //sumamos el subtotal del precio del articulo x la cantidad;
                    Total += (Cantidad * Precio);
                    lblTotal.Text = Total.ToString("$ 0.00");//Mostramos en pantalla el total acumulado
                    //Agregar Articulo ala Lista en el Control
                    AddArtItem(TotalArticulos.ToString("00"), Articulo.DESCRIPCION, Articulo.ID, Cantidad, Articulo.UNIDAD, Precio, (Cantidad * Precio),Articulo.INV);

                    txtCodigo.Focus();
                    txtCodigo.Text = "";

                }
                else
                { //Si el articulo no existe

                    Funciones.Message("NO EXISTE EL ARTICULO!");
                }



            }
        }

        private void FRM_Cbza_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Total > 0)
            {
                if (MessageBox.Show("Desea Salir de la Cbza?", "Desea salir ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        #endregion








    }
}
>>>>>>> 208d285bee0af146f9f98d8836b287fa0df48b6b
