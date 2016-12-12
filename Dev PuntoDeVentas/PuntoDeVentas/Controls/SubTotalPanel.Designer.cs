namespace PuntoDeVentas.Controls {
    partial class SubTotalPanel {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            PuntoDeVentas.InputAppearance inputAppearance1 = new PuntoDeVentas.InputAppearance();
            this.pnlSubTotalContainer = new System.Windows.Forms.Panel();
            this.lblSubtotalTitle = new System.Windows.Forms.Label();
            this.lblArticuloCount = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPago = new PuntoDeVentas.Controls.InputTextBox();
            this.pnlSubTotalContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSubTotalContainer
            // 
            this.pnlSubTotalContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlSubTotalContainer.BackgroundImage = global::PuntoDeVentas.Properties.Resources.SUB_BG1;
            this.pnlSubTotalContainer.Controls.Add(this.lblSubtotalTitle);
            this.pnlSubTotalContainer.Controls.Add(this.lblArticuloCount);
            this.pnlSubTotalContainer.Controls.Add(this.lblSubTotal);
            this.pnlSubTotalContainer.Location = new System.Drawing.Point(14, 27);
            this.pnlSubTotalContainer.Name = "pnlSubTotalContainer";
            this.pnlSubTotalContainer.Size = new System.Drawing.Size(319, 125);
            this.pnlSubTotalContainer.TabIndex = 26;
            // 
            // lblSubtotalTitle
            // 
            this.lblSubtotalTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            this.lblSubtotalTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubtotalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblSubtotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(0)))));
            this.lblSubtotalTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSubtotalTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotalTitle.Name = "lblSubtotalTitle";
            this.lblSubtotalTitle.Size = new System.Drawing.Size(319, 19);
            this.lblSubtotalTitle.TabIndex = 24;
            this.lblSubtotalTitle.Text = "SUBTOTAL";
            this.lblSubtotalTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblArticuloCount
            // 
            this.lblArticuloCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            this.lblArticuloCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblArticuloCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblArticuloCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(0)))));
            this.lblArticuloCount.Location = new System.Drawing.Point(0, 103);
            this.lblArticuloCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArticuloCount.Name = "lblArticuloCount";
            this.lblArticuloCount.Size = new System.Drawing.Size(319, 22);
            this.lblArticuloCount.TabIndex = 23;
            this.lblArticuloCount.Text = "CANT. ARTICULOS : 00";
            this.lblArticuloCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            this.lblSubTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubTotal.Font = new System.Drawing.Font("Consolas", 40.75F, System.Drawing.FontStyle.Bold);
            this.lblSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(0)))));
            this.lblSubTotal.Location = new System.Drawing.Point(0, 0);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(319, 125);
            this.lblSubTotal.TabIndex = 13;
            this.lblSubTotal.Text = "$ 000.00";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblEfectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.lblEfectivo.Location = new System.Drawing.Point(586, 44);
            this.lblEfectivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(195, 33);
            this.lblEfectivo.TabIndex = 28;
            this.lblEfectivo.Text = "[EFECTIVO]";
            this.lblEfectivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.label4.Location = new System.Drawing.Point(378, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Efectivo Recibido : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.label3.Location = new System.Drawing.Point(499, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Pago : ";
            // 
            // txtPago
            // 
            this.txtPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txtPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPago.Font = new System.Drawing.Font("Consolas", 14F);
            this.txtPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            this.txtPago.Location = new System.Drawing.Point(590, 104);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(191, 22);
            inputAppearance1.ActiveBackcolor = System.Drawing.Color.Empty;
            inputAppearance1.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            inputAppearance1.BorderActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            inputAppearance1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            inputAppearance1.BorderPadding = 7;
            inputAppearance1.BorderRadius = 5;
            inputAppearance1.BorderSize = 1;
            inputAppearance1.Draw = PuntoDeVentas.InputAppearance.DrawStyle.Line;
            inputAppearance1.Forecolor = System.Drawing.Color.Empty;
            inputAppearance1.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            inputAppearance1.TextPlaceholder = "$ Pago";
            this.txtPago.Style = inputAppearance1;
            this.txtPago.TabIndex = 25;
            this.txtPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._PagoKeyPress);
            // 
            // SubTotalPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.pnlSubTotalContainer);
            this.Controls.Add(this.lblEfectivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.MaximumSize = new System.Drawing.Size(0, 171);
            this.MinimumSize = new System.Drawing.Size(843, 171);
            this.Name = "SubTotalPanel";
            this.Size = new System.Drawing.Size(843, 171);
            this.pnlSubTotalContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSubTotalContainer;
        private System.Windows.Forms.Label lblArticuloCount;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblEfectivo;
        private System.Windows.Forms.Label label4;        
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSubtotalTitle;
        private InputTextBox txtPago;
    }
}
