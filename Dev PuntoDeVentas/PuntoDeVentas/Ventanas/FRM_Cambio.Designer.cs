namespace PuntoDeVentas
{
    partial class FRM_Cambio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Cambio));
            this.lblMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContinuar = new PuntoDeVentas.Controls.InputTextBox();
            this.SuspendLayout();
            // 
            // lblWndPanelTitle
            // 
            this.lblWndPanelTitle.Location = new System.Drawing.Point(3, 3);
            this.lblWndPanelTitle.Size = new System.Drawing.Size(385, 58);
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI Semilight", 24.25F);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            this.lblMessage.Location = new System.Drawing.Point(24, 28);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(578, 161);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "[MESSAGE]";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(150, 211);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desea Imprimir el Tiket   [Y/N]  ?";
            // 
            // txtContinuar
            // 
            this.txtContinuar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.txtContinuar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContinuar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContinuar.ForeColor = System.Drawing.Color.Gray;
            this.txtContinuar.Location = new System.Drawing.Point(371, 209);
            this.txtContinuar.MaxLength = 1;
            this.txtContinuar.Name = "txtContinuar";
            this.txtContinuar.Size = new System.Drawing.Size(37, 22);
            inputAppearance1.ActiveBackcolor = System.Drawing.Color.Empty;
            inputAppearance1.ActiveForecolor = System.Drawing.Color.Gray;
            inputAppearance1.BorderActiveColor = System.Drawing.Color.Empty;
            inputAppearance1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            inputAppearance1.BorderPadding = 4;
            inputAppearance1.BorderRadius = 6;
            inputAppearance1.BorderSize = 1;
            inputAppearance1.Draw = PuntoDeVentas.InputAppearance.DrawStyle.Fill;
            inputAppearance1.Forecolor = System.Drawing.Color.Gray;
            inputAppearance1.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            inputAppearance1.TextPlaceholder = "";
            this.txtContinuar.Style = inputAppearance1;
            this.txtContinuar.TabIndex = 4;
            this.txtContinuar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContinuar.TextChanged += new System.EventHandler(this.txtContinuar_TextChanged);
            // 
            // FRM_Cambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(620, 248);
            this.ControlBox = false;
            this.Controls.Add(this.txtContinuar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "FRM_Cambio";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.ShowTitleLabel = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            this.Controls.SetChildIndex(this.lblMessage, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblWndPanelTitle, 0);
            this.Controls.SetChildIndex(this.txtContinuar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;


        private System.Windows.Forms.Label label1;
        private Controls.InputTextBox txtContinuar;
    }

}