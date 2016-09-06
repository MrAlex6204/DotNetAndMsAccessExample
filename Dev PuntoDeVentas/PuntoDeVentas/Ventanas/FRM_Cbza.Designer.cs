
namespace PuntoDeVentas {

    partial class FRM_Cbza {
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFechaHra = new System.Windows.Forms.Label();
            this.tmrFechayHra = new System.Windows.Forms.Timer(this.components);
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCajero = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.pnlStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblPanelTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPanelTitle
            // 
            this.lblPanelTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPanelTitle.BackgroundImage = global::PuntoDeVentas.Properties.Resources.SUB_BG1;
            this.lblPanelTitle.Controls.Add(this.lblFechaHra);
            this.lblPanelTitle.Controls.Add(this.pictureBox1);
            this.lblPanelTitle.Controls.Add(this.lblCajero);
            this.lblPanelTitle.Size = new System.Drawing.Size(1221, 55);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.lblTitle.Location = new System.Drawing.Point(4, 62);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(979, 60);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "[EMPRESA]";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFechaHra
            // 
            this.lblFechaHra.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFechaHra.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.lblFechaHra.Location = new System.Drawing.Point(0, 0);
            this.lblFechaHra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHra.Name = "lblFechaHra";
            this.lblFechaHra.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblFechaHra.Size = new System.Drawing.Size(832, 55);
            this.lblFechaHra.TabIndex = 0;
            this.lblFechaHra.Text = "[dddd,dd-MMMM-yyyy hh:mm tt]";
            this.lblFechaHra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrFechayHra
            // 
            this.tmrFechayHra.Enabled = true;
            this.tmrFechayHra.Interval = 60;
            this.tmrFechayHra.Tick += new System.EventHandler(this.tmrFechayHra_Tick);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Light", 30F);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(190)))), ((int)(((byte)(74)))));
            this.lblTotal.Image = global::PuntoDeVentas.Properties.Resources.SUB_BG1;
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(235, 77);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "$ 0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::PuntoDeVentas.Properties.Resources.SUB_BG1;
            this.panel2.Location = new System.Drawing.Point(985, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 580);
            this.panel2.TabIndex = 21;
            // 
            // lblCajero
            // 
            this.lblCajero.AutoSize = true;
            this.lblCajero.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCajero.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.lblCajero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCajero.Location = new System.Drawing.Point(1148, 0);
            this.lblCajero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCajero.Name = "lblCajero";
            this.lblCajero.Padding = new System.Windows.Forms.Padding(0, 17, 6, 0);
            this.lblCajero.Size = new System.Drawing.Size(73, 37);
            this.lblCajero.TabIndex = 4;
            this.lblCajero.Text = "[CAJERO]";
            this.lblCajero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::PuntoDeVentas.Properties.Resources.SUB_BG1;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlStatus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 721);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 52);
            this.panel1.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::PuntoDeVentas.Properties.Resources.INPUT_SHORT;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Controls.Add(this.txtCantidad);
            this.panel4.Location = new System.Drawing.Point(11, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(90, 33);
            this.panel4.TabIndex = 20;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 13.5F);
            this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtCantidad.Location = new System.Drawing.Point(14, 3);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(61, 24);
            this.txtCantidad.TabIndex = 8;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::PuntoDeVentas.Properties.Resources.SEARCH_BAR;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.txtCodigo);
            this.panel3.Location = new System.Drawing.Point(129, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 33);
            this.panel3.TabIndex = 19;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 13.5F);
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtCodigo.Location = new System.Drawing.Point(37, 3);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(236, 24);
            this.txtCodigo.TabIndex = 10;
            this.txtCodigo.Text = "[PRODUCT CODE]";
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ArticuloCode_KeyDown);
            // 
            // pnlStatus
            // 
            this.pnlStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatus.BackColor = System.Drawing.Color.Transparent;
            this.pnlStatus.Font = new System.Drawing.Font("Segoe UI Light", 10.75F);
            this.pnlStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.pnlStatus.Location = new System.Drawing.Point(430, 10);
            this.pnlStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(778, 33);
            this.pnlStatus.TabIndex = 18;
            this.pnlStatus.Text = "[STATUS]";
            this.pnlStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(100, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "@";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::PuntoDeVentas.Properties.Resources.us_1;
            this.pictureBox1.Location = new System.Drawing.Point(1101, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pictureBox1.Size = new System.Drawing.Size(47, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = global::PuntoDeVentas.Properties.Resources.SUB_BG1;
            this.panel6.Controls.Add(this.lblTotal);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(985, 641);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(235, 77);
            this.panel6.TabIndex = 22;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BackgroundImage = global::PuntoDeVentas.Properties.Resources.SUB_BG1;
            this.panel7.Location = new System.Drawing.Point(-108, 421);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(348, 0);
            this.panel7.TabIndex = 22;
            // 
            // FRM_Cbza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1221, 773);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "FRM_Cbza";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cobranza";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Cbza_FormClosing);
            this.Load += new System.EventHandler(this.FRM_Cbza_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Wnd_KeyDown);
            this.Controls.SetChildIndex(this.lblPanelTitle, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.lblPanelTitle.ResumeLayout(false);
            this.lblPanelTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFechaHra;
        private System.Windows.Forms.Label lblCajero;
        private System.Windows.Forms.Timer tmrFechayHra;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label pnlStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        


    }
}




