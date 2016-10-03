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
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.picArticuloFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWndPanelTitle
            // 
            this.lblWndPanelTitle.Size = new System.Drawing.Size(678, 55);
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdAceptar.AutoSize = true;
            this.cmdAceptar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cmdAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAceptar.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.cmdAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.cmdAceptar.Location = new System.Drawing.Point(256, 348);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(80, 33);
            this.cmdAceptar.TabIndex = 6;
            this.cmdAceptar.Text = "Guardar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdCancelar.AutoSize = true;
            this.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancelar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cmdCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelar.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.cmdCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.cmdCancelar.Location = new System.Drawing.Point(345, 348);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(80, 33);
            this.cmdCancelar.TabIndex = 7;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // chkInventario
            // 
            this.chkInventario.AutoSize = true;
            this.chkInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkInventario.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.chkInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.chkInventario.Location = new System.Drawing.Point(144, 258);
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
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label5.Location = new System.Drawing.Point(6, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 45);
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
            inputAppearance1.TextPlaceholder = "Codigo";
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
            inputAppearance2.TextPlaceholder = "Descripcion";
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
            this.txtPrecio.Location = new System.Drawing.Point(55, 183);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(134, 22);
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
            // 
            // txtUnidad
            // 
            this.txtUnidad.BackColor = System.Drawing.Color.White;
            this.txtUnidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnidad.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtUnidad.ForeColor = System.Drawing.Color.Silver;
            this.txtUnidad.Location = new System.Drawing.Point(212, 183);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(231, 22);
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
            inputAppearance4.TextPlaceholder = "Unidad";
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
            // FRM_AgregarArticulo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.cmdCancelar;
            this.ClientSize = new System.Drawing.Size(682, 393);
            this.ControlBox = false;
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
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdAceptar);
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
            this.Controls.SetChildIndex(this.cmdAceptar, 0);
            this.Controls.SetChildIndex(this.cmdCancelar, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.picArticuloFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.Button cmdCancelar;
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
    }

}