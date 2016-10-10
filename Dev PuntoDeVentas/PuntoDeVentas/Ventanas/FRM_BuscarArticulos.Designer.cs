namespace PuntoDeVentas
{
    partial class FRM_ConsultarArticulos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            PuntoDeVentas.InputAppearance inputAppearance1 = new PuntoDeVentas.InputAppearance();
            PuntoDeVentas.Controls.ControlAppearance controlAppearance1 = new PuntoDeVentas.Controls.ControlAppearance();
            PuntoDeVentas.Controls.WindowControlBox.Buttons buttons1 = new PuntoDeVentas.Controls.WindowControlBox.Buttons();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ConsultarArticulos));
            this.Gridbuscar = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new PuntoDeVentas.Controls.InputTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictArticulo = new System.Windows.Forms.PictureBox();
            this.wndControlBox = new PuntoDeVentas.Controls.WindowControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.Gridbuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWndPanelTitle
            // 
            this.lblWndPanelTitle.Size = new System.Drawing.Size(807, 45);
            // 
            // Gridbuscar
            // 
            this.Gridbuscar.AllowUserToAddRows = false;
            this.Gridbuscar.AllowUserToDeleteRows = false;
            this.Gridbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gridbuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Gridbuscar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Gridbuscar.BackgroundColor = System.Drawing.Color.White;
            this.Gridbuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Gridbuscar.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridbuscar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Gridbuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gridbuscar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Gridbuscar.GridColor = System.Drawing.SystemColors.Control;
            this.Gridbuscar.Location = new System.Drawing.Point(16, 103);
            this.Gridbuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Gridbuscar.MultiSelect = false;
            this.Gridbuscar.Name = "Gridbuscar";
            this.Gridbuscar.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridbuscar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Gridbuscar.RowHeadersVisible = false;
            this.Gridbuscar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Gridbuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Gridbuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Gridbuscar.Size = new System.Drawing.Size(511, 362);
            this.Gridbuscar.StandardTab = true;
            this.Gridbuscar.TabIndex = 2;
            this.Gridbuscar.SelectionChanged += new System.EventHandler(this.SelectedRow_Change);
            this.Gridbuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gridbuscar_KeyDown);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtBuscar.ForeColor = System.Drawing.Color.Silver;
            this.txtBuscar.Location = new System.Drawing.Point(27, 58);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(758, 22);
            inputAppearance1.ActiveBackcolor = System.Drawing.Color.Empty;
            inputAppearance1.ActiveForecolor = System.Drawing.Color.Gray;
            inputAppearance1.BorderActiveColor = System.Drawing.Color.Silver;
            inputAppearance1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            inputAppearance1.BorderPadding = 9;
            inputAppearance1.BorderRadius = 5;
            inputAppearance1.BorderSize = 1;
            inputAppearance1.Draw = PuntoDeVentas.InputAppearance.DrawStyle.Line;
            inputAppearance1.Forecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            inputAppearance1.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            inputAppearance1.TextPlaceholder = "Buscar articulo ...";
            this.txtBuscar.Style = inputAppearance1;
            this.txtBuscar.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(154)))), ((int)(((byte)(169)))));
            this.label5.Location = new System.Drawing.Point(13, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 45);
            this.label5.TabIndex = 34;
            this.label5.Text = "Buscar Articulo";
            // 
            // pictArticulo
            // 
            this.pictArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictArticulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictArticulo.Location = new System.Drawing.Point(534, 103);
            this.pictArticulo.Name = "pictArticulo";
            this.pictArticulo.Size = new System.Drawing.Size(260, 289);
            this.pictArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictArticulo.TabIndex = 35;
            this.pictArticulo.TabStop = false;
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
            controlAppearance1.MouseOverBackColor = System.Drawing.Color.Empty;
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
            this.wndControlBox.Location = new System.Drawing.Point(779, -2);
            this.wndControlBox.Name = "wndControlBox";
            this.wndControlBox.Size = new System.Drawing.Size(35, 36);
            this.wndControlBox.TabIndex = 36;
            // 
            // FRM_ConsultarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 479);
            this.ControlBox = false;
            this.Controls.Add(this.wndControlBox);
            this.Controls.Add(this.pictArticulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.Gridbuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ConsultarArticulos";
            this.ShowTitleLabel = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar Articulos";
            this.WindowBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(184)))), ((int)(((byte)(120)))));
            this.Load += new System.EventHandler(this.FRM_ConsultarArticuloscs_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            this.Controls.SetChildIndex(this.Gridbuscar, 0);
            this.Controls.SetChildIndex(this.lblWndPanelTitle, 0);
            this.Controls.SetChildIndex(this.txtBuscar, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.pictArticulo, 0);
            this.Controls.SetChildIndex(this.wndControlBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Gridbuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Gridbuscar;
        private Controls.InputTextBox txtBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictArticulo;
        private Controls.WindowControlBox wndControlBox;
    }

}