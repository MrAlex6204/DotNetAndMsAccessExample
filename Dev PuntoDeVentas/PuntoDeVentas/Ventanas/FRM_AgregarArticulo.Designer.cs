namespace PuntoDeVentas
{
    partial class FRM_AgregarArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PuntoDeVentas.InputAppearance inputAppearance1 = new PuntoDeVentas.InputAppearance();
            PuntoDeVentas.InputAppearance inputAppearance2 = new PuntoDeVentas.InputAppearance();
            PuntoDeVentas.InputAppearance inputAppearance3 = new PuntoDeVentas.InputAppearance();
            PuntoDeVentas.InputAppearance inputAppearance4 = new PuntoDeVentas.InputAppearance();
            PuntoDeVentas.Controls.ControlAppearance controlAppearance1 = new PuntoDeVentas.Controls.ControlAppearance();
            PuntoDeVentas.Controls.WindowControlBox.Buttons buttons1 = new PuntoDeVentas.Controls.WindowControlBox.Buttons();
            PuntoDeVentas.InputAppearance inputAppearance5 = new PuntoDeVentas.InputAppearance();
            PuntoDeVentas.Controls.ControlAppearance controlAppearance2 = new PuntoDeVentas.Controls.ControlAppearance();
            PuntoDeVentas.Controls.ControlAppearance controlAppearance3 = new PuntoDeVentas.Controls.ControlAppearance();
            this.chkInventario = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new PuntoDeVentas.Controls.InputTextBox();
            this.txtDesc = new PuntoDeVentas.Controls.InputTextBox();
            this.txtPrecio = new PuntoDeVentas.Controls.InputTextBox();
            this.txtUnidad = new PuntoDeVentas.Controls.InputTextBox();
            this.cmdExaminar = new System.Windows.Forms.Button();
            this.picArticuloFoto = new System.Windows.Forms.PictureBox();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.wndControlBox = new PuntoDeVentas.Controls.WindowControlBox();
            this.lblCurrencySymbol = new System.Windows.Forms.Label();
            this.lblCostoCurrency = new System.Windows.Forms.Label();
            this.txtCosto = new PuntoDeVentas.Controls.InputTextBox();
            this.cmdGuardar = new PuntoDeVentas.LabelButton();
            this.cmdCancelar = new PuntoDeVentas.LabelButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picArticuloFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWndPanelTitle
            // 
            this.lblWndPanelTitle.Size = new System.Drawing.Size(678, 55);
            // 
            // chkInventario
            // 
            this.chkInventario.AutoSize = true;
            this.chkInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkInventario.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.chkInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.chkInventario.Location = new System.Drawing.Point(170, 323);
            this.chkInventario.Name = "chkInventario";
            this.chkInventario.Size = new System.Drawing.Size(166, 25);
            this.chkInventario.TabIndex = 4;
            this.chkInventario.Text = "Agregar al Inventario";
            this.chkInventario.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(413, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(154)))), ((int)(((byte)(169)))));
            this.label5.Location = new System.Drawing.Point(6, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 45);
            this.label5.TabIndex = 30;
            this.label5.Text = "Nuevo articulo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtCodigo.ForeColor = System.Drawing.Color.Silver;
            this.txtCodigo.Location = new System.Drawing.Point(56, 67);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(342, 22);
            inputAppearance1.ActiveBackcolor = System.Drawing.Color.Empty;
            inputAppearance1.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            inputAppearance1.BorderActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            inputAppearance1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            inputAppearance1.BorderPadding = 7;
            inputAppearance1.BorderRadius = 5;
            inputAppearance1.BorderSize = 1;
            inputAppearance1.Draw = PuntoDeVentas.InputAppearance.DrawStyle.Line;
            inputAppearance1.Forecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            inputAppearance1.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            inputAppearance1.TextPlaceholder = "Codigo del articulo";
            this.txtCodigo.Style = inputAppearance1;
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtDesc.ForeColor = System.Drawing.Color.Silver;
            this.txtDesc.Location = new System.Drawing.Point(56, 129);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(387, 22);
            inputAppearance2.ActiveBackcolor = System.Drawing.Color.Empty;
            inputAppearance2.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            inputAppearance2.BorderActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            inputAppearance2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            inputAppearance2.BorderPadding = 7;
            inputAppearance2.BorderRadius = 5;
            inputAppearance2.BorderSize = 1;
            inputAppearance2.Draw = PuntoDeVentas.InputAppearance.DrawStyle.Line;
            inputAppearance2.Forecolor = System.Drawing.Color.Silver;
            inputAppearance2.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            inputAppearance2.TextPlaceholder = "Ingrese una descripcion";
            this.txtDesc.Style = inputAppearance2;
            this.txtDesc.TabIndex = 1;
            this.txtDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesc_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtPrecio.ForeColor = System.Drawing.Color.Silver;
            this.txtPrecio.Location = new System.Drawing.Point(164, 181);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(70, 22);
            inputAppearance3.ActiveBackcolor = System.Drawing.Color.Empty;
            inputAppearance3.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            inputAppearance3.BorderActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            inputAppearance3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            inputAppearance3.BorderPadding = 7;
            inputAppearance3.BorderRadius = 5;
            inputAppearance3.BorderSize = 1;
            inputAppearance3.Draw = PuntoDeVentas.InputAppearance.DrawStyle.Line;
            inputAppearance3.Forecolor = System.Drawing.Color.Silver;
            inputAppearance3.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            inputAppearance3.TextPlaceholder = "$ Precio";
            this.txtPrecio.Style = inputAppearance3;
            this.txtPrecio.TabIndex = 2;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            this.txtPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.Field_Valid);
            // 
            // txtUnidad
            // 
            this.txtUnidad.BackColor = System.Drawing.Color.White;
            this.txtUnidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnidad.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtUnidad.ForeColor = System.Drawing.Color.Silver;
            this.txtUnidad.Location = new System.Drawing.Point(53, 256);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(390, 22);
            inputAppearance4.ActiveBackcolor = System.Drawing.Color.Empty;
            inputAppearance4.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            inputAppearance4.BorderActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            inputAppearance4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            inputAppearance4.BorderPadding = 7;
            inputAppearance4.BorderRadius = 5;
            inputAppearance4.BorderSize = 1;
            inputAppearance4.Draw = PuntoDeVentas.InputAppearance.DrawStyle.Line;
            inputAppearance4.Forecolor = System.Drawing.Color.Silver;
            inputAppearance4.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            inputAppearance4.TextPlaceholder = "Ingrese la unidad del articulo";
            this.txtUnidad.Style = inputAppearance4;
            this.txtUnidad.TabIndex = 3;
            this.txtUnidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnidad_KeyPress);
            // 
            // cmdExaminar
            // 
            this.cmdExaminar.AutoSize = true;
            this.cmdExaminar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cmdExaminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExaminar.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.cmdExaminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.cmdExaminar.Location = new System.Drawing.Point(472, 274);
            this.cmdExaminar.Name = "cmdExaminar";
            this.cmdExaminar.Size = new System.Drawing.Size(191, 33);
            this.cmdExaminar.TabIndex = 5;
            this.cmdExaminar.Text = "Examinar ...";
            this.cmdExaminar.UseVisualStyleBackColor = true;
            this.cmdExaminar.Click += new System.EventHandler(this.cmdExaminar_Click);
            // 
            // picArticuloFoto
            // 
            this.picArticuloFoto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picArticuloFoto.Location = new System.Drawing.Point(472, 46);
            this.picArticuloFoto.Name = "picArticuloFoto";
            this.picArticuloFoto.Size = new System.Drawing.Size(191, 222);
            this.picArticuloFoto.TabIndex = 33;
            this.picArticuloFoto.TabStop = false;
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.ForeColor = System.Drawing.Color.Maroon;
            this.lblErrorMsg.Location = new System.Drawing.Point(53, 101);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(173, 13);
            this.lblErrorMsg.TabIndex = 34;
            this.lblErrorMsg.Text = "Este codigo ya existe! [ARTICULO]";
            // 
            // wndControlBox
            // 
            this.wndControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            controlAppearance1.BackColor = System.Drawing.Color.Empty;
            controlAppearance1.BorderColor = System.Drawing.Color.Empty;
            controlAppearance1.BorderPadding = 0;
            controlAppearance1.BorderSize = 0;
            controlAppearance1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            controlAppearance1.CheckedBackColor = System.Drawing.Color.Empty;
            controlAppearance1.Forecolor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            controlAppearance1.MouseDownBackColor = System.Drawing.Color.Empty;
            controlAppearance1.MouseOverBackColor = System.Drawing.Color.Empty;
            controlAppearance1.MouseOverBorderColor = System.Drawing.Color.Empty;
            controlAppearance1.MouseOverForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.wndControlBox.Appearance = controlAppearance1;
            this.wndControlBox.AutoSize = true;
            this.wndControlBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wndControlBox.BackColor = System.Drawing.Color.Transparent;
            buttons1.Maximize = false;
            buttons1.Minimize = false;
            buttons1.MoveButtons = false;
            this.wndControlBox.ControlButtons = buttons1;
            this.wndControlBox.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.wndControlBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.wndControlBox.Location = new System.Drawing.Point(650, -2);
            this.wndControlBox.Name = "wndControlBox";
            this.wndControlBox.Size = new System.Drawing.Size(35, 36);
            this.wndControlBox.TabIndex = 35;
            // 
            // lblCurrencySymbol
            // 
            this.lblCurrencySymbol.BackColor = System.Drawing.Color.White;
            this.lblCurrencySymbol.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lblCurrencySymbol.ForeColor = System.Drawing.Color.Silver;
            this.lblCurrencySymbol.Location = new System.Drawing.Point(112, 180);
            this.lblCurrencySymbol.Name = "lblCurrencySymbol";
            this.lblCurrencySymbol.Size = new System.Drawing.Size(43, 23);
            this.lblCurrencySymbol.TabIndex = 36;
            this.lblCurrencySymbol.Text = "[$$]";
            this.lblCurrencySymbol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCostoCurrency
            // 
            this.lblCostoCurrency.BackColor = System.Drawing.Color.White;
            this.lblCostoCurrency.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lblCostoCurrency.ForeColor = System.Drawing.Color.Silver;
            this.lblCostoCurrency.Location = new System.Drawing.Point(328, 179);
            this.lblCostoCurrency.Name = "lblCostoCurrency";
            this.lblCostoCurrency.Size = new System.Drawing.Size(43, 23);
            this.lblCostoCurrency.TabIndex = 39;
            this.lblCostoCurrency.Text = "[$$]";
            this.lblCostoCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCosto
            // 
            this.txtCosto.BackColor = System.Drawing.Color.White;
            this.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCosto.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtCosto.ForeColor = System.Drawing.Color.Silver;
            this.txtCosto.Location = new System.Drawing.Point(382, 180);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(70, 22);
            inputAppearance5.ActiveBackcolor = System.Drawing.Color.Empty;
            inputAppearance5.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            inputAppearance5.BorderActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            inputAppearance5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            inputAppearance5.BorderPadding = 7;
            inputAppearance5.BorderRadius = 5;
            inputAppearance5.BorderSize = 1;
            inputAppearance5.Draw = PuntoDeVentas.InputAppearance.DrawStyle.Line;
            inputAppearance5.Forecolor = System.Drawing.Color.Silver;
            inputAppearance5.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            inputAppearance5.TextPlaceholder = "$ Costo";
            this.txtCosto.Style = inputAppearance5;
            this.txtCosto.TabIndex = 38;
            this.txtCosto.Validating += new System.ComponentModel.CancelEventHandler(this.Field_Valid);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdGuardar.BackColor = System.Drawing.Color.White;
            this.cmdGuardar.BorderRadius = 5;
            this.cmdGuardar.FlatAppearance.BorderSize = 0;
            this.cmdGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGuardar.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdGuardar.Location = new System.Drawing.Point(53, 367);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(103, 34);
            controlAppearance2.BackColor = System.Drawing.Color.White;
            controlAppearance2.BorderColor = System.Drawing.Color.WhiteSmoke;
            controlAppearance2.BorderPadding = 5;
            controlAppearance2.BorderSize = 1;
            controlAppearance2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            controlAppearance2.CheckedBackColor = System.Drawing.Color.Empty;
            controlAppearance2.Forecolor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            controlAppearance2.MouseDownBackColor = System.Drawing.Color.Silver;
            controlAppearance2.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            controlAppearance2.MouseOverBorderColor = System.Drawing.Color.Gray;
            controlAppearance2.MouseOverForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.cmdGuardar.Style = controlAppearance2;
            this.cmdGuardar.TabIndex = 40;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancelar.BackColor = System.Drawing.Color.White;
            this.cmdCancelar.BorderRadius = 5;
            this.cmdCancelar.FlatAppearance.BorderSize = 0;
            this.cmdCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelar.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdCancelar.Location = new System.Drawing.Point(560, 367);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(103, 34);
            controlAppearance3.BackColor = System.Drawing.Color.White;
            controlAppearance3.BorderColor = System.Drawing.Color.WhiteSmoke;
            controlAppearance3.BorderPadding = 5;
            controlAppearance3.BorderSize = 1;
            controlAppearance3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            controlAppearance3.CheckedBackColor = System.Drawing.Color.Empty;
            controlAppearance3.Forecolor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            controlAppearance3.MouseDownBackColor = System.Drawing.Color.Silver;
            controlAppearance3.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            controlAppearance3.MouseOverBorderColor = System.Drawing.Color.Gray;
            controlAppearance3.MouseOverForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.cmdCancelar.Style = controlAppearance3;
            this.cmdCancelar.TabIndex = 41;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(271, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "Costo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(49, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "Precio";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(50, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "Unidad";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FRM_AgregarArticulo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 433);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.lblCostoCurrency);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.lblCurrencySymbol);
            this.Controls.Add(this.wndControlBox);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.picArticuloFoto);
            this.Controls.Add(this.cmdExaminar);
            this.Controls.Add(this.chkInventario);
            this.Controls.Add(this.txtUnidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_AgregarArticulo";
            this.ShowTitleLabel = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Articulos";
            this.WindowBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            this.Load += new System.EventHandler(this.FRM_AgregarArticulo_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FRM_AgregarArticulo_KeyPress);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.lblWndPanelTitle, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.txtDesc, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            this.Controls.SetChildIndex(this.txtUnidad, 0);
            this.Controls.SetChildIndex(this.chkInventario, 0);
            this.Controls.SetChildIndex(this.cmdExaminar, 0);
            this.Controls.SetChildIndex(this.picArticuloFoto, 0);
            this.Controls.SetChildIndex(this.lblErrorMsg, 0);
            this.Controls.SetChildIndex(this.wndControlBox, 0);
            this.Controls.SetChildIndex(this.lblCurrencySymbol, 0);
            this.Controls.SetChildIndex(this.txtCosto, 0);
            this.Controls.SetChildIndex(this.lblCostoCurrency, 0);
            this.Controls.SetChildIndex(this.cmdGuardar, 0);
            this.Controls.SetChildIndex(this.cmdCancelar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picArticuloFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkInventario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private Controls.InputTextBox txtCodigo;
        private Controls.InputTextBox txtDesc;
        private Controls.InputTextBox txtPrecio;
        private Controls.InputTextBox txtUnidad;
        private System.Windows.Forms.Button cmdExaminar;
        private System.Windows.Forms.PictureBox picArticuloFoto;
        private System.Windows.Forms.Label lblErrorMsg;
        private Controls.WindowControlBox wndControlBox;
        private System.Windows.Forms.Label lblCurrencySymbol;
        private System.Windows.Forms.Label lblCostoCurrency;
        private Controls.InputTextBox txtCosto;
        private LabelButton cmdGuardar;
        private LabelButton cmdCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }

}