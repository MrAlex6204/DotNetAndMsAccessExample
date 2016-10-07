﻿
namespace PuntoDeVentas {

    partial class FRM_Cbza {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Cbza));
            PuntoDeVentas.Controls.ControlAppearance controlAppearance1 = new PuntoDeVentas.Controls.ControlAppearance();
            PuntoDeVentas.Controls.WindowControlBox.Buttons buttons1 = new PuntoDeVentas.Controls.WindowControlBox.Buttons();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFechaHra = new System.Windows.Forms.Label();
            this.tmrFechayHra = new System.Windows.Forms.Timer(this.components);
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.picArticulo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCajero = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.pnlStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblArticuloCount = new System.Windows.Forms.Label();
            this.LstArticulos = new PuntoDeVentas.ArticuloList();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.windowControlBox1 = new PuntoDeVentas.Controls.WindowControlBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblWndPanelTitle.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArticulo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWndPanelTitle
            // 
            this.lblWndPanelTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblWndPanelTitle.BackgroundImage = global::PuntoDeVentas.Properties.Resources.SUB_BG1;
            this.lblWndPanelTitle.Controls.Add(this.windowControlBox1);
            this.lblWndPanelTitle.Controls.Add(this.lblCajero);
            this.lblWndPanelTitle.Controls.Add(this.pictureBox1);
            this.lblWndPanelTitle.Padding = new System.Windows.Forms.Padding(1);
            this.lblWndPanelTitle.Size = new System.Drawing.Size(1224, 55);
            this.lblWndPanelTitle.Controls.SetChildIndex(this.pictureBox1, 0);
            this.lblWndPanelTitle.Controls.SetChildIndex(this.lblCajero, 0);
            this.lblWndPanelTitle.Controls.SetChildIndex(this.windowControlBox1, 0);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.lblTitle.Location = new System.Drawing.Point(6, 64);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(938, 60);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "[EMPRESA]";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFechaHra
            // 
            this.lblFechaHra.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFechaHra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblFechaHra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(0)))));
            this.lblFechaHra.Location = new System.Drawing.Point(0, 0);
            this.lblFechaHra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHra.Name = "lblFechaHra";
            this.lblFechaHra.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblFechaHra.Size = new System.Drawing.Size(269, 18);
            this.lblFechaHra.TabIndex = 0;
            this.lblFechaHra.Text = "[dddd,dd-MMMM-yyyy hh:mm tt]";
            this.lblFechaHra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tmrFechayHra
            // 
            this.tmrFechayHra.Enabled = true;
            this.tmrFechayHra.Interval = 60;
            this.tmrFechayHra.Tick += new System.EventHandler(this.tmrFechayHra_Tick);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("Consolas", 24.75F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(0, 18);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(269, 63);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "$ 00.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::PuntoDeVentas.Properties.Resources.SUB_BG1;
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(954, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 606);
            this.panel2.TabIndex = 21;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.picArticulo);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 404);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(269, 202);
            this.panel8.TabIndex = 24;
            // 
            // picArticulo
            // 
            this.picArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picArticulo.Location = new System.Drawing.Point(0, 0);
            this.picArticulo.Name = "picArticulo";
            this.picArticulo.Size = new System.Drawing.Size(269, 202);
            this.picArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picArticulo.TabIndex = 0;
            this.picArticulo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(112)))), ((int)(((byte)(113)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2);
            this.label2.Size = new System.Drawing.Size(269, 394);
            this.label2.TabIndex = 19;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // lblCajero
            // 
            this.lblCajero.AutoSize = true;
            this.lblCajero.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCajero.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.lblCajero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCajero.Location = new System.Drawing.Point(48, 1);
            this.lblCajero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCajero.Name = "lblCajero";
            this.lblCajero.Padding = new System.Windows.Forms.Padding(0, 15, 6, 0);
            this.lblCajero.Size = new System.Drawing.Size(73, 35);
            this.lblCajero.TabIndex = 4;
            this.lblCajero.Text = "[CAJERO]";
            this.lblCajero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::PuntoDeVentas.Properties.Resources.SUB_BG1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlStatus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(2, 751);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 52);
            this.panel1.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::PuntoDeVentas.Properties.Resources.INPUT_SHORT;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Controls.Add(this.txtCantidad);
            this.panel4.Location = new System.Drawing.Point(11, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(90, 33);
            this.panel4.TabIndex = 20;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 13.5F);
            this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtCantidad.Location = new System.Drawing.Point(14, 3);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(61, 24);
            this.txtCantidad.TabIndex = 8;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::PuntoDeVentas.Properties.Resources.SEARCH_BAR;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.txtCodigo);
            this.panel3.Location = new System.Drawing.Point(129, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 33);
            this.panel3.TabIndex = 19;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 13.5F);
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtCodigo.Location = new System.Drawing.Point(37, 3);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(236, 24);
            this.txtCodigo.TabIndex = 10;
            this.txtCodigo.Text = "[PRODUCT CODE]";
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ArticuloCode_KeyDown);
            // 
            // pnlStatus
            // 
            this.pnlStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatus.BackColor = System.Drawing.Color.Transparent;
            this.pnlStatus.Font = new System.Drawing.Font("Segoe UI Light", 10.75F);
            this.pnlStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.pnlStatus.Location = new System.Drawing.Point(430, 5);
            this.pnlStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(781, 40);
            this.pnlStatus.TabIndex = 18;
            this.pnlStatus.Text = "[STATUS]";
            this.pnlStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(100, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "@";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::PuntoDeVentas.Properties.Resources.us_1;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pictureBox1.Size = new System.Drawing.Size(47, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            this.panel5.Controls.Add(this.lblArticuloCount);
            this.panel5.Controls.Add(this.lblTotal);
            this.panel5.Controls.Add(this.lblFechaHra);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(269, 81);
            this.panel5.TabIndex = 23;
            // 
            // lblArticuloCount
            // 
            this.lblArticuloCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            this.lblArticuloCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblArticuloCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblArticuloCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(0)))));
            this.lblArticuloCount.Location = new System.Drawing.Point(0, 59);
            this.lblArticuloCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArticuloCount.Name = "lblArticuloCount";
            this.lblArticuloCount.Size = new System.Drawing.Size(269, 22);
            this.lblArticuloCount.TabIndex = 23;
            this.lblArticuloCount.Text = "CANT. ARTICULOS : 00";
            this.lblArticuloCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LstArticulos
            // 
            this.LstArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstArticulos.BackColor = System.Drawing.Color.Transparent;
            this.LstArticulos.Location = new System.Drawing.Point(2, 144);
            this.LstArticulos.Name = "LstArticulos";
            this.LstArticulos.Size = new System.Drawing.Size(942, 601);
            this.LstArticulos.TabIndex = 0;
            this.LstArticulos.OnListChange += new PuntoDeVentas.ArticuloList.OnChangeHandler(this.LstArticulos_OnListChange);
            this.LstArticulos.OnSelectedItemChange += new System.ArticuloItemCollection.OnSelectedItemChangeHanlder(this.LstArticulos_OnSelectedItemChange);
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI Light", 10.75F);
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblDireccion.Location = new System.Drawing.Point(6, 119);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.lblDireccion.Size = new System.Drawing.Size(937, 22);
            this.lblDireccion.TabIndex = 23;
            this.lblDireccion.Text = "[DIRECCION DEL NEGOCIO]";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // windowControlBox1
            // 
            this.windowControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            controlAppearance1.BackColor = System.Drawing.Color.Transparent;
            controlAppearance1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            controlAppearance1.BorderPadding = 0;
            controlAppearance1.BorderSize = 0;
            controlAppearance1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            controlAppearance1.CheckedBackColor = System.Drawing.Color.Empty;
            controlAppearance1.Forecolor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            controlAppearance1.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            controlAppearance1.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            controlAppearance1.MouseOverBorderColor = System.Drawing.Color.Empty;
            controlAppearance1.MouseOverForecolor = System.Drawing.Color.Empty;
            this.windowControlBox1.Appearance = controlAppearance1;
            this.windowControlBox1.AutoSize = true;
            this.windowControlBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.windowControlBox1.BackColor = System.Drawing.Color.Transparent;
            buttons1.Maximize = true;
            buttons1.Minimize = true;
            buttons1.MoveButtons = true;
            this.windowControlBox1.ControlButtons = buttons1;
            this.windowControlBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.windowControlBox1.Location = new System.Drawing.Point(1056, 9);
            this.windowControlBox1.Name = "windowControlBox1";
            this.windowControlBox1.Size = new System.Drawing.Size(159, 36);
            this.windowControlBox1.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = global::PuntoDeVentas.Properties.Resources.SUB_BG1;
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Location = new System.Drawing.Point(954, 668);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(269, 81);
            this.panel6.TabIndex = 25;
            // 
            // FRM_Cbza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1228, 805);
            this.ControlBox = false;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LstArticulos);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.MoveWindowBox = true;
            this.Name = "FRM_Cbza";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cobranza";
            this.WindowBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Cbza_FormClosing);
            this.Load += new System.EventHandler(this.FRM_Cbza_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Wnd_KeyDown);
            this.Controls.SetChildIndex(this.LstArticulos, 0);
            this.Controls.SetChildIndex(this.lblWndPanelTitle, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.lblDireccion, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.lblWndPanelTitle.ResumeLayout(false);
            this.lblWndPanelTitle.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picArticulo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFechaHra;
        private System.Windows.Forms.Label lblCajero;
        private System.Windows.Forms.Timer tmrFechayHra;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label pnlStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private PuntoDeVentas.ArticuloList LstArticulos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblArticuloCount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox picArticulo;
        private Controls.WindowControlBox windowControlBox1;
        private System.Windows.Forms.Panel panel6;

    }
}




