namespace PuntoDeVentas
{
    partial class FRM_RegistrarEntrada
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
            PuntoDeVentas.Controls.ControlAppearance controlAppearance1 = new PuntoDeVentas.Controls.ControlAppearance();
            PuntoDeVentas.Controls.WindowControlBox.Buttons buttons1 = new PuntoDeVentas.Controls.WindowControlBox.Buttons();
            PuntoDeVentas.InputAppearance inputAppearance1 = new PuntoDeVentas.InputAppearance();
            PuntoDeVentas.InputAppearance inputAppearance2 = new PuntoDeVentas.InputAppearance();
            PuntoDeVentas.InputAppearance inputAppearance3 = new PuntoDeVentas.InputAppearance();
            PuntoDeVentas.InputAppearance inputAppearance4 = new PuntoDeVentas.InputAppearance();
            PuntoDeVentas.Controls.ControlAppearance controlAppearance2 = new PuntoDeVentas.Controls.ControlAppearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_RegistrarEntrada));
            this.wndControlBox = new PuntoDeVentas.Controls.WindowControlBox();
            this.lblArticulo = new PuntoDeVentas.Controls.InputTextBox();
            this.lblCodigo = new PuntoDeVentas.Controls.InputTextBox();
            this.lblUsr = new PuntoDeVentas.Controls.InputTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new PuntoDeVentas.Controls.InputTextBox();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.cmdRegistrar = new PuntoDeVentas.LabelButton();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWndPanelTitle
            // 
            this.lblWndPanelTitle.Location = new System.Drawing.Point(3, 3);
            this.lblWndPanelTitle.Size = new System.Drawing.Size(814, 58);
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
            controlAppearance1.MouseOverBackColor = System.Drawing.Color.Transparent;
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
            this.wndControlBox.Location = new System.Drawing.Point(785, -1);
            this.wndControlBox.Name = "wndControlBox";
            this.wndControlBox.Size = new System.Drawing.Size(35, 36);
            this.wndControlBox.TabIndex = 48;
            // 
            // lblArticulo
            // 
            this.lblArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblArticulo.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lblArticulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            this.lblArticulo.Location = new System.Drawing.Point(268, 119);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.ReadOnly = true;
            this.lblArticulo.Size = new System.Drawing.Size(529, 25);
            inputAppearance1.ActiveBackcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            inputAppearance1.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            inputAppearance1.BorderActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            inputAppearance1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            inputAppearance1.BorderPadding = 7;
            inputAppearance1.BorderRadius = 5;
            inputAppearance1.BorderSize = 1;
            inputAppearance1.Draw = PuntoDeVentas.InputAppearance.DrawStyle.Both;
            inputAppearance1.Forecolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            inputAppearance1.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            inputAppearance1.TextPlaceholder = "Articulo";
            this.lblArticulo.Style = inputAppearance1;
            this.lblArticulo.TabIndex = 49;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            this.lblCodigo.Location = new System.Drawing.Point(21, 119);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.ReadOnly = true;
            this.lblCodigo.Size = new System.Drawing.Size(223, 25);
            inputAppearance2.ActiveBackcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            inputAppearance2.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            inputAppearance2.BorderActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            inputAppearance2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            inputAppearance2.BorderPadding = 7;
            inputAppearance2.BorderRadius = 5;
            inputAppearance2.BorderSize = 1;
            inputAppearance2.Draw = PuntoDeVentas.InputAppearance.DrawStyle.Both;
            inputAppearance2.Forecolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            inputAppearance2.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            inputAppearance2.TextPlaceholder = "Codigo";
            this.lblCodigo.Style = inputAppearance2;
            this.lblCodigo.TabIndex = 50;
            // 
            // lblUsr
            // 
            this.lblUsr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblUsr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblUsr.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lblUsr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            this.lblUsr.Location = new System.Drawing.Point(21, 217);
            this.lblUsr.Name = "lblUsr";
            this.lblUsr.ReadOnly = true;
            this.lblUsr.Size = new System.Drawing.Size(776, 25);
            inputAppearance3.ActiveBackcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            inputAppearance3.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            inputAppearance3.BorderActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            inputAppearance3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            inputAppearance3.BorderPadding = 7;
            inputAppearance3.BorderRadius = 5;
            inputAppearance3.BorderSize = 1;
            inputAppearance3.Draw = PuntoDeVentas.InputAppearance.DrawStyle.Both;
            inputAppearance3.Forecolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            inputAppearance3.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            inputAppearance3.TextPlaceholder = "Usuario";
            this.lblUsr.Style = inputAppearance3;
            this.lblUsr.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            this.label3.Location = new System.Drawing.Point(263, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "Articulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            this.label1.Location = new System.Drawing.Point(16, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            this.label4.Location = new System.Drawing.Point(16, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 25);
            this.label4.TabIndex = 55;
            this.label4.Text = "Usuario quien registra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            this.label2.Location = new System.Drawing.Point(140, 294);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 56;
            this.label2.Text = "Cantidad de entrada :";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            this.txtCantidad.Location = new System.Drawing.Point(337, 294);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 25);
            inputAppearance4.ActiveBackcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            inputAppearance4.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            inputAppearance4.BorderActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            inputAppearance4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            inputAppearance4.BorderPadding = 7;
            inputAppearance4.BorderRadius = 5;
            inputAppearance4.BorderSize = 1;
            inputAppearance4.Draw = PuntoDeVentas.InputAppearance.DrawStyle.Both;
            inputAppearance4.Forecolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            inputAppearance4.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            inputAppearance4.TextPlaceholder = "Cantidad";
            this.txtCantidad.Style = inputAppearance4;
            this.txtCantidad.TabIndex = 57;
            this.txtCantidad.MouseLeave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            this.lblUnidad.Location = new System.Drawing.Point(451, 294);
            this.lblUnidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(94, 25);
            this.lblUnidad.TabIndex = 58;
            this.lblUnidad.Text = "[UNIDAD]";
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmdRegistrar.BorderRadius = 5;
            this.cmdRegistrar.FlatAppearance.BorderSize = 0;
            this.cmdRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmdRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmdRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            this.cmdRegistrar.Location = new System.Drawing.Point(309, 393);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(145, 29);
            controlAppearance2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            controlAppearance2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            controlAppearance2.BorderPadding = 7;
            controlAppearance2.BorderSize = 1;
            controlAppearance2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            controlAppearance2.CheckedBackColor = System.Drawing.Color.Empty;
            controlAppearance2.Forecolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            controlAppearance2.MouseDownBackColor = System.Drawing.Color.Empty;
            controlAppearance2.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            controlAppearance2.MouseOverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            controlAppearance2.MouseOverForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.cmdRegistrar.Style = controlAppearance2;
            this.cmdRegistrar.TabIndex = 59;
            this.cmdRegistrar.Text = "Registrar entrada";
            this.cmdRegistrar.UseVisualStyleBackColor = false;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // lbl
            // 
            this.lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            this.lbl.Image = global::PuntoDeVentas.Properties.Resources.deliver;
            this.lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl.Location = new System.Drawing.Point(238, 15);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(344, 50);
            this.lbl.TabIndex = 20;
            this.lbl.Text = "Registro de Inventario";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_RegistrarEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 452);
            this.ControlBox = false;
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wndControlBox);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblUsr);
            this.Controls.Add(this.lblCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_RegistrarEntrada";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.ShowTitleLabel = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowBorderColor = System.Drawing.Color.Goldenrod;
            this.Load += new System.EventHandler(this.FRM_RegistrarEntrada_Load);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.lblUsr, 0);
            this.Controls.SetChildIndex(this.txtCantidad, 0);
            this.Controls.SetChildIndex(this.lblArticulo, 0);
            this.Controls.SetChildIndex(this.lbl, 0);
            this.Controls.SetChildIndex(this.lblWndPanelTitle, 0);
            this.Controls.SetChildIndex(this.wndControlBox, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblUnidad, 0);
            this.Controls.SetChildIndex(this.cmdRegistrar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private Controls.WindowControlBox wndControlBox;
        private Controls.InputTextBox lblArticulo;
        private Controls.InputTextBox lblCodigo;
        private Controls.InputTextBox lblUsr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Controls.InputTextBox txtCantidad;
        private System.Windows.Forms.Label lblUnidad;
        private LabelButton cmdRegistrar;
    }

}