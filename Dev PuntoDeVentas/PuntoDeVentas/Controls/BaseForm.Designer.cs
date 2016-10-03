namespace PuntoDeVentas.Controls {
    partial class BaseForm {
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
            this.lblWndPanelTitle = new System.Windows.Forms.Panel();
            this.WindowBox = new PuntoDeVentas.Controls.WindowControlBox();
            this.lblWndPanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWndPanelTitle
            // 
            this.lblWndPanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblWndPanelTitle.Controls.Add(this.WindowBox);
            this.lblWndPanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWndPanelTitle.Location = new System.Drawing.Point(2, 2);
            this.lblWndPanelTitle.Name = "lblWndPanelTitle";
            this.lblWndPanelTitle.Size = new System.Drawing.Size(1157, 58);
            this.lblWndPanelTitle.TabIndex = 0;
            this.lblWndPanelTitle.DoubleClick += new System.EventHandler(this.lblPanelTitle_DoubleClick);
            this.lblWndPanelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Wnd_MouseDown);
            // 
            // WindowBox
            // 
            this.WindowBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            controlAppearance1.BackColor = System.Drawing.Color.Empty;
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
            this.WindowBox.Appearance = controlAppearance1;
            this.WindowBox.AutoSize = true;
            this.WindowBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WindowBox.BackColor = System.Drawing.Color.Transparent;
            buttons1.Maximize = true;
            buttons1.Minimize = true;
            buttons1.MoveButtons = true;
            this.WindowBox.ControlButtons = buttons1;
            this.WindowBox.ForeColor = System.Drawing.SystemColors.Control;
            this.WindowBox.Location = new System.Drawing.Point(991, 10);
            this.WindowBox.Name = "WindowBox";
            this.WindowBox.Size = new System.Drawing.Size(159, 36);
            this.WindowBox.TabIndex = 1;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1161, 240);
            this.Controls.Add(this.lblWndPanelTitle);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BaseForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BaseForm_Paint);
            this.lblWndPanelTitle.ResumeLayout(false);
            this.lblWndPanelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel lblWndPanelTitle;
        private WindowControlBox WindowBox;

    }
}