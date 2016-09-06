namespace PuntoDeVentas{
    partial class ArticuloList {
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
            this.pnlCobranza = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pnlCobranza
            // 
            this.pnlCobranza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCobranza.AutoScroll = true;
            this.pnlCobranza.AutoScrollMargin = new System.Drawing.Size(25, 0);
            this.pnlCobranza.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlCobranza.Location = new System.Drawing.Point(0, 0);
            this.pnlCobranza.Name = "pnlCobranza";
            this.pnlCobranza.Size = new System.Drawing.Size(546, 402);
            this.pnlCobranza.TabIndex = 24;
            this.pnlCobranza.WrapContents = false;
            // 
            // ArticuloList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlCobranza);
            this.Name = "ArticuloList";
            this.Size = new System.Drawing.Size(519, 402);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlCobranza;
    }
}
