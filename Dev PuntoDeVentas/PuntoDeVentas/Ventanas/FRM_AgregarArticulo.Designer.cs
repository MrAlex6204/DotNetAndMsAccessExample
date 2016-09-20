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
            ((System.ComponentModel.ISupportInitialize)(this.picArticuloFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWndPanelTitle
            // 
            this.lblWndPanelTitle.Size = new System.Drawing.Size(682, 55);
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
            this.cmdAceptar.Location = new System.Drawing.Point(256, 345);
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
            this.cmdCancelar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cmdCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelar.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.cmdCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.cmdCancelar.Location = new System.Drawing.Point(345, 345);
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
            this.chkInventario.TabIndex = 5;
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
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
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
            this.label5.Location = new System.Drawing.Point(4, -1);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 45);
            this.label5.TabIndex = 30;
            this.label5.Text = "Nuevo articulo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.BorderOuterActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            this.txtCodigo.BorderOuterColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodigo.BorderOuterDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.txtCodigo.BorderOuterSize = 7;
            this.txtCodigo.BorderOuterStyle = PuntoDeVentas.Controls.InputTextBox.OuterBorderStyle.Line;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.txtCodigo.Location = new System.Drawing.Point(56, 67);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Placeholder = "Codigo";
            this.txtCodigo.Size = new System.Drawing.Size(342, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.BorderOuterActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(194)))), ((int)(((byte)(120)))));
            this.txtDesc.BorderOuterColor = System.Drawing.Color.WhiteSmoke;
            this.txtDesc.BorderOuterDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.txtDesc.BorderOuterSize = 7;
            this.txtDesc.BorderOuterStyle = PuntoDeVentas.Controls.InputTextBox.OuterBorderStyle.Line;
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.txtDesc.Location = new System.Drawing.Point(56, 120);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Placeholder = "Descripcion";
            this.txtDesc.Size = new System.Drawing.Size(387, 22);
            this.txtDesc.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.BorderOuterActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            this.txtPrecio.BorderOuterColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrecio.BorderOuterDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.txtPrecio.BorderOuterSize = 7;
            this.txtPrecio.BorderOuterStyle = PuntoDeVentas.Controls.InputTextBox.OuterBorderStyle.Line;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.txtPrecio.Location = new System.Drawing.Point(55, 174);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Placeholder = "$ Precio";
            this.txtPrecio.Size = new System.Drawing.Size(134, 22);
            this.txtPrecio.TabIndex = 3;
            // 
            // txtUnidad
            // 
            this.txtUnidad.BackColor = System.Drawing.Color.White;
            this.txtUnidad.BorderOuterActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            this.txtUnidad.BorderOuterColor = System.Drawing.Color.WhiteSmoke;
            this.txtUnidad.BorderOuterDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.txtUnidad.BorderOuterSize = 7;
            this.txtUnidad.BorderOuterStyle = PuntoDeVentas.Controls.InputTextBox.OuterBorderStyle.Line;
            this.txtUnidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnidad.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtUnidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.txtUnidad.Location = new System.Drawing.Point(212, 174);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Placeholder = "Unidad";
            this.txtUnidad.Size = new System.Drawing.Size(231, 22);
            this.txtUnidad.TabIndex = 4;
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
            this.cmdExaminar.TabIndex = 32;
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
            // FRM_AgregarArticulo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 390);
            this.ControlBox = false;
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
            this.Load += new System.EventHandler(this.FRM_AgregarArticulo_Load);
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
    }

}