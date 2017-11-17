namespace PuntoDeVentas {
    partial class FRM_DepositosDeEfectivo {
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
            PuntoDeVentas.Controls.ControlAppearance controlAppearance1 = new PuntoDeVentas.Controls.ControlAppearance();
            PuntoDeVentas.Controls.WindowControlBox.Buttons buttons1 = new PuntoDeVentas.Controls.WindowControlBox.Buttons();
            PuntoDeVentas.InputAppearance inputAppearance1 = new PuntoDeVentas.InputAppearance();
            PuntoDeVentas.Controls.ControlAppearance controlAppearance2 = new PuntoDeVentas.Controls.ControlAppearance();
            PuntoDeVentas.Controls.ControlAppearance controlAppearance3 = new PuntoDeVentas.Controls.ControlAppearance();
            this.wndControlBox = new PuntoDeVentas.Controls.WindowControlBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMonto = new PuntoDeVentas.Controls.InputTextBox();
            this.lblMontoLabel = new System.Windows.Forms.Label();
            this.cmdGuardarCambios = new PuntoDeVentas.LabelButton();
            this.cmdRetirarDeposito = new PuntoDeVentas.LabelButton();
            this.lblCurrencyCode = new System.Windows.Forms.Label();
            this.lblCajeroName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWndPanelTitle
            // 
            this.lblWndPanelTitle.Size = new System.Drawing.Size(845, 58);
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
            this.wndControlBox.Location = new System.Drawing.Point(817, -1);
            this.wndControlBox.Name = "wndControlBox";
            this.wndControlBox.Size = new System.Drawing.Size(35, 36);
            this.wndControlBox.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            this.label5.Image = global::PuntoDeVentas.Properties.Resources.iconmonstr_checkout_2_32;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(6, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(364, 45);
            this.label5.TabIndex = 38;
            this.label5.Text = "Deposito de caja";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.txtMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            this.txtMonto.Location = new System.Drawing.Point(457, 113);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(159, 25);
            inputAppearance1.ActiveBackcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            inputAppearance1.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            inputAppearance1.BorderActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            inputAppearance1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            inputAppearance1.BorderPadding = 7;
            inputAppearance1.BorderRadius = 5;
            inputAppearance1.BorderSize = 1;
            inputAppearance1.Draw = PuntoDeVentas.InputAppearance.DrawStyle.Fill;
            inputAppearance1.Forecolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            inputAppearance1.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            inputAppearance1.TextPlaceholder = "$ Monto";
            this.txtMonto.Style = inputAppearance1;
            this.txtMonto.TabIndex = 39;
            // 
            // lblMontoLabel
            // 
            this.lblMontoLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lblMontoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            this.lblMontoLabel.Location = new System.Drawing.Point(120, 113);
            this.lblMontoLabel.Name = "lblMontoLabel";
            this.lblMontoLabel.Size = new System.Drawing.Size(321, 25);
            this.lblMontoLabel.TabIndex = 48;
            this.lblMontoLabel.Text = "Monto del deposito efectuado : $";
            this.lblMontoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdGuardarCambios
            // 
            this.cmdGuardarCambios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmdGuardarCambios.BorderRadius = 5;
            this.cmdGuardarCambios.FlatAppearance.BorderSize = 0;
            this.cmdGuardarCambios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmdGuardarCambios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmdGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGuardarCambios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            this.cmdGuardarCambios.Location = new System.Drawing.Point(674, 185);
            this.cmdGuardarCambios.Name = "cmdGuardarCambios";
            this.cmdGuardarCambios.Size = new System.Drawing.Size(145, 29);
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
            this.cmdGuardarCambios.Style = controlAppearance2;
            this.cmdGuardarCambios.TabIndex = 49;
            this.cmdGuardarCambios.Text = "Guardar cambio";
            this.cmdGuardarCambios.UseVisualStyleBackColor = false;
            this.cmdGuardarCambios.Click += new System.EventHandler(this.cmdGuardarCambios_Click);
            // 
            // cmdRetirarDeposito
            // 
            this.cmdRetirarDeposito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdRetirarDeposito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmdRetirarDeposito.BorderRadius = 5;
            this.cmdRetirarDeposito.FlatAppearance.BorderSize = 0;
            this.cmdRetirarDeposito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmdRetirarDeposito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.cmdRetirarDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRetirarDeposito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            this.cmdRetirarDeposito.Location = new System.Drawing.Point(66, 185);
            this.cmdRetirarDeposito.Name = "cmdRetirarDeposito";
            this.cmdRetirarDeposito.Size = new System.Drawing.Size(145, 29);
            controlAppearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            controlAppearance3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            controlAppearance3.BorderPadding = 7;
            controlAppearance3.BorderSize = 1;
            controlAppearance3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            controlAppearance3.CheckedBackColor = System.Drawing.Color.Empty;
            controlAppearance3.Forecolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            controlAppearance3.MouseDownBackColor = System.Drawing.Color.Empty;
            controlAppearance3.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            controlAppearance3.MouseOverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            controlAppearance3.MouseOverForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.cmdRetirarDeposito.Style = controlAppearance3;
            this.cmdRetirarDeposito.TabIndex = 50;
            this.cmdRetirarDeposito.Text = "Retirar deposito";
            this.cmdRetirarDeposito.UseVisualStyleBackColor = false;
            this.cmdRetirarDeposito.Click += new System.EventHandler(this.cmdRetirarDeposito_Click);
            // 
            // lblCurrencyCode
            // 
            this.lblCurrencyCode.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lblCurrencyCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            this.lblCurrencyCode.Location = new System.Drawing.Point(631, 113);
            this.lblCurrencyCode.Name = "lblCurrencyCode";
            this.lblCurrencyCode.Size = new System.Drawing.Size(78, 25);
            this.lblCurrencyCode.TabIndex = 51;
            this.lblCurrencyCode.Text = "MXN";
            this.lblCurrencyCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCajeroName
            // 
            this.lblCajeroName.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lblCajeroName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            this.lblCajeroName.Location = new System.Drawing.Point(161, 65);
            this.lblCajeroName.Name = "lblCajeroName";
            this.lblCajeroName.Size = new System.Drawing.Size(525, 25);
            this.lblCajeroName.TabIndex = 52;
            this.lblCajeroName.Text = "Cajero: [NOMBRE DEL CAJERO]";
            this.lblCajeroName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRM_DepositosDeEfectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 243);
            this.ControlBox = false;
            this.Controls.Add(this.lblCajeroName);
            this.Controls.Add(this.lblCurrencyCode);
            this.Controls.Add(this.cmdRetirarDeposito);
            this.Controls.Add(this.cmdGuardarCambios);
            this.Controls.Add(this.lblMontoLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wndControlBox);
            this.Controls.Add(this.txtMonto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_DepositosDeEfectivo";
            this.ShowTitleLabel = false;
            this.Text = "FRM_DepositosDeEfectivo";
            this.WindowBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            this.Controls.SetChildIndex(this.txtMonto, 0);
            this.Controls.SetChildIndex(this.lblWndPanelTitle, 0);
            this.Controls.SetChildIndex(this.wndControlBox, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.lblMontoLabel, 0);
            this.Controls.SetChildIndex(this.cmdGuardarCambios, 0);
            this.Controls.SetChildIndex(this.cmdRetirarDeposito, 0);
            this.Controls.SetChildIndex(this.lblCurrencyCode, 0);
            this.Controls.SetChildIndex(this.lblCajeroName, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.WindowControlBox wndControlBox;
        private System.Windows.Forms.Label label5;
        private Controls.InputTextBox txtMonto;
        private System.Windows.Forms.Label lblMontoLabel;
        private LabelButton cmdGuardarCambios;
        private LabelButton cmdRetirarDeposito;
        private System.Windows.Forms.Label lblCurrencyCode;
        private System.Windows.Forms.Label lblCajeroName;

    }
}