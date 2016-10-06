namespace PuntoDeVentas{
    public partial class ArticuloList {
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
            this.articuloItem1 = new System.ArticuloItem();
            this.lblNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCobranza.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCobranza
            // 
            this.pnlCobranza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCobranza.AutoScroll = true;
            this.pnlCobranza.AutoScrollMargin = new System.Drawing.Size(20, 20);
            this.pnlCobranza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnlCobranza.Controls.Add(this.articuloItem1);
            this.pnlCobranza.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlCobranza.Location = new System.Drawing.Point(0, 58);
            this.pnlCobranza.Name = "pnlCobranza";
            this.pnlCobranza.Size = new System.Drawing.Size(967, 366);
            this.pnlCobranza.TabIndex = 24;
            this.pnlCobranza.WrapContents = false;
            // 
            // articuloItem1
            // 
            this.articuloItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.articuloItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            this.articuloItem1.IsDeleted = false;
            this.articuloItem1.IsSelected = false;
            this.articuloItem1.Location = new System.Drawing.Point(3, 3);
            this.articuloItem1.MinimumSize = new System.Drawing.Size(942, 108);
            this.articuloItem1.Name = "articuloItem1";
            this.articuloItem1.Position = 0;
            this.articuloItem1.Size = new System.Drawing.Size(942, 108);
            this.articuloItem1.TabIndex = 0;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Segoe UI Light", 30.25F);
            this.lblNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            this.lblNo.Location = new System.Drawing.Point(31, -1);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(49, 55);
            this.lblNo.TabIndex = 25;
            this.lblNo.Text = "#";
            this.lblNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(96, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 37);
            this.label1.TabIndex = 26;
            this.label1.Text = "DESCRIPTION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::PuntoDeVentas.Properties.Resources.LINE;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(-7, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 11);
            this.panel1.TabIndex = 27;
            // 
            // ArticuloList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.pnlCobranza);
            this.Controls.Add(this.label1);
            this.Name = "ArticuloList";
            this.Size = new System.Drawing.Size(942, 402);
            this.pnlCobranza.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlCobranza;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.ArticuloItem articuloItem1;
    }
}
