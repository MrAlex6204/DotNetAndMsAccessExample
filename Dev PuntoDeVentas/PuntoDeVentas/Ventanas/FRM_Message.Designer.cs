namespace PuntoDeVentas
{
    partial class FRM_Message
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
            this.components = new System.ComponentModel.Container();
            PuntoDeVentas.Controls.ControlAppearance controlAppearance1 = new PuntoDeVentas.Controls.ControlAppearance();
            PuntoDeVentas.Controls.WindowControlBox.Buttons buttons1 = new PuntoDeVentas.Controls.WindowControlBox.Buttons();
            this.lblMessage = new System.Windows.Forms.Label();
            this.TRM = new System.Windows.Forms.Timer(this.components);
            this.wndBox = new PuntoDeVentas.Controls.WindowControlBox();
            this.SuspendLayout();
            // 
            // lblWndPanelTitle
            // 
            this.lblWndPanelTitle.Location = new System.Drawing.Point(3, 3);
            this.lblWndPanelTitle.Size = new System.Drawing.Size(165, 58);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            this.lblMessage.Location = new System.Drawing.Point(5, 28);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Padding = new System.Windows.Forms.Padding(18, 0, 18, 18);
            this.lblMessage.Size = new System.Drawing.Size(120, 38);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "[MESSAGE]";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TRM
            // 
            this.TRM.Enabled = true;
            this.TRM.Interval = 1500;
            this.TRM.Tick += new System.EventHandler(this.TRM_Tick);
            // 
            // wndBox
            // 
            this.wndBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            controlAppearance1.BackColor = System.Drawing.Color.Transparent;
            controlAppearance1.BorderColor = System.Drawing.Color.Empty;
            controlAppearance1.BorderPadding = 0;
            controlAppearance1.BorderSize = 0;
            controlAppearance1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            controlAppearance1.CheckedBackColor = System.Drawing.Color.Empty;
            controlAppearance1.Forecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            controlAppearance1.MouseDownBackColor = System.Drawing.Color.Empty;
            controlAppearance1.MouseOverBackColor = System.Drawing.Color.Transparent;
            controlAppearance1.MouseOverBorderColor = System.Drawing.Color.Empty;
            controlAppearance1.MouseOverForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.wndBox.Appearance = controlAppearance1;
            this.wndBox.AutoSize = true;
            this.wndBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wndBox.BackColor = System.Drawing.Color.Transparent;
            buttons1.Maximize = false;
            buttons1.Minimize = false;
            buttons1.MoveButtons = false;
            this.wndBox.ControlButtons = buttons1;
            this.wndBox.ForeColor = System.Drawing.SystemColors.Control;
            this.wndBox.Location = new System.Drawing.Point(140, -2);
            this.wndBox.Name = "wndBox";
            this.wndBox.Size = new System.Drawing.Size(35, 36);
            this.wndBox.TabIndex = 1;
            // 
            // FRM_Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(171, 73);
            this.ControlBox = false;
            this.Controls.Add(this.wndBox);
            this.Controls.Add(this.lblMessage);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Message";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.ShowTitleLabel = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.WindowBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FRM_Message_KeyPress);
            this.Controls.SetChildIndex(this.lblMessage, 0);
            this.Controls.SetChildIndex(this.lblWndPanelTitle, 0);
            this.Controls.SetChildIndex(this.wndBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TRM;
        private System.Windows.Forms.Label lblMessage;
        private Controls.WindowControlBox wndBox;
    }
 }
