namespace PuntoDeVentas
{
    partial class FRM_Main
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
            this.windowControlBox1 = new PuntoDeVentas.Controls.WindowControlBox();
            this.SuspendLayout();
            // 
            // lblWndPanelTitle
            // 
            this.lblWndPanelTitle.Size = new System.Drawing.Size(772, 38);
            // 
            // windowControlBox1
            // 
            controlAppearance1.BorderColor = System.Drawing.Color.Empty;
            controlAppearance1.BorderSize = 0;
            controlAppearance1.CheckedBackColor = System.Drawing.Color.Empty;
            controlAppearance1.Forecolor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            controlAppearance1.MouseDownBackColor = System.Drawing.Color.Empty;
            controlAppearance1.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            controlAppearance1.MouseOverForecolor = System.Drawing.Color.Green;
            this.windowControlBox1.Appearance = controlAppearance1;
            this.windowControlBox1.AutoSize = true;
            this.windowControlBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.windowControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.windowControlBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.windowControlBox1.Location = new System.Drawing.Point(507, 109);
            this.windowControlBox1.Name = "windowControlBox1";
            this.windowControlBox1.Size = new System.Drawing.Size(159, 36);
            this.windowControlBox1.TabIndex = 1;
            this.windowControlBox1.Load += new System.EventHandler(this.windowControlBox1_Load_1);
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.ClientSize = new System.Drawing.Size(776, 321);
            this.ControlBoxAnchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Controls.Add(this.windowControlBox1);
            this.Name = "FRM_Main";
            this.Controls.SetChildIndex(this.lblWndPanelTitle, 0);
            this.Controls.SetChildIndex(this.windowControlBox1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.WindowControlBox windowControlBox1;




    }

}