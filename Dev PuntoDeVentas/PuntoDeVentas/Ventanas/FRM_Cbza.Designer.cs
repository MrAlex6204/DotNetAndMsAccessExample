
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
            this.lblCajero = new System.Windows.Forms.Label();
            this.tmrFechayHra = new System.Windows.Forms.Timer(this.components);
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlCobranza = new System.Windows.Forms.Panel();
            this.pnlStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPanelTitle.SuspendLayout();
            this.pnlCobranza.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPanelTitle
            // 
            this.lblPanelTitle.Controls.Add(this.lblFechaHra);
            this.lblPanelTitle.Controls.Add(this.lblTitle);
            this.lblPanelTitle.Size = new System.Drawing.Size(1173, 46);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 1);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(886, 39);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "[EMPRESA]";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFechaHra
            // 
            this.lblFechaHra.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F);
            this.lblFechaHra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.lblFechaHra.Location = new System.Drawing.Point(798, 2);
            this.lblFechaHra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHra.Name = "lblFechaHra";
            this.lblFechaHra.Size = new System.Drawing.Size(371, 38);
            this.lblFechaHra.TabIndex = 0;
            this.lblFechaHra.Text = "[FECHA Y HRA]";
            this.lblFechaHra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCajero
            // 
            this.lblCajero.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            this.lblCajero.Location = new System.Drawing.Point(94, 0);
            this.lblCajero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCajero.Name = "lblCajero";
            this.lblCajero.Size = new System.Drawing.Size(793, 39);
            this.lblCajero.TabIndex = 4;
            this.lblCajero.Text = "[CAJERO]";
            this.lblCajero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCajero.Click += new System.EventHandler(this.lblCajero_Click);
            // 
            // tmrFechayHra
            // 
            this.tmrFechayHra.Enabled = true;
            this.tmrFechayHra.Tick += new System.EventHandler(this.tmrFechayHra_Tick);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(142)))), ((int)(((byte)(57)))));
            this.txtCantidad.Location = new System.Drawing.Point(12, 17);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(133, 28);
            this.txtCantidad.TabIndex = 8;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(148, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "@";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(142)))), ((int)(((byte)(57)))));
            this.txtCodigo.Location = new System.Drawing.Point(189, 17);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(517, 28);
            this.txtCodigo.TabIndex = 10;
            this.txtCodigo.Text = "[PRODUCT CODE]";
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ArticuloCode_KeyDown);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(142)))), ((int)(((byte)(57)))));
            this.lblTotal.Location = new System.Drawing.Point(893, 609);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(276, 91);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "$ 0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCobranza
            // 
            this.pnlCobranza.AutoScroll = true;
            this.pnlCobranza.AutoScrollMinSize = new System.Drawing.Size(0, 1);
            this.pnlCobranza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnlCobranza.Controls.Add(this.panel3);
            this.pnlCobranza.Location = new System.Drawing.Point(-1, 49);
            this.pnlCobranza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCobranza.Name = "pnlCobranza";
            this.pnlCobranza.Size = new System.Drawing.Size(891, 653);
            this.pnlCobranza.TabIndex = 0;
            // 
            // pnlStatus
            // 
            this.pnlStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlStatus.BackColor = System.Drawing.Color.Transparent;
            this.pnlStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(142)))), ((int)(((byte)(57)))));
            this.pnlStatus.Location = new System.Drawing.Point(4, 48);
            this.pnlStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(766, 17);
            this.pnlStatus.TabIndex = 18;
            this.pnlStatus.Text = "[STATUS]";
            this.pnlStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.pnlStatus);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 703);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 70);
            this.panel1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(89)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 39);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cajero :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Location = new System.Drawing.Point(893, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 557);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblCajero);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(891, 38);
            this.panel3.TabIndex = 0;
            // 
            // FRM_Cbza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1173, 773);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCobranza);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
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
            this.Controls.SetChildIndex(this.pnlCobranza, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.lblPanelTitle.ResumeLayout(false);
            this.pnlCobranza.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlCobranza;
        private System.Windows.Forms.Label pnlStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;


    }
}




