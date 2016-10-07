namespace PuntoDeVentas
{
    partial class FRM_Login
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
            PuntoDeVentas.InputAppearance inputAppearance2 = new PuntoDeVentas.InputAppearance();
            PuntoDeVentas.InputAppearance inputAppearance3 = new PuntoDeVentas.InputAppearance();
            PuntoDeVentas.InputAppearance inputAppearance1 = new PuntoDeVentas.InputAppearance();
            this.txtUser = new PuntoDeVentas.Controls.InputTextBox();
            this.txtPassword = new PuntoDeVentas.Controls.InputTextBox();
            this.inputTextBox1 = new PuntoDeVentas.Controls.InputTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.lblWndPanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWndPanelTitle
            // 
            this.lblWndPanelTitle.Controls.Add(this.inputTextBox1);
            this.lblWndPanelTitle.Size = new System.Drawing.Size(580, 51);
            this.lblWndPanelTitle.Controls.SetChildIndex(this.inputTextBox1, 0);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.txtUser.Location = new System.Drawing.Point(155, 266);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(283, 22);
            inputAppearance2.ActiveBackcolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            inputAppearance2.ActiveForecolor = System.Drawing.Color.Gray;
            inputAppearance2.BorderActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            inputAppearance2.BorderColor = System.Drawing.Color.Empty;
            inputAppearance2.BorderPadding = 9;
            inputAppearance2.BorderRadius = 5;
            inputAppearance2.BorderSize = 1;
            inputAppearance2.Draw = PuntoDeVentas.InputAppearance.DrawStyle.Fill;
            inputAppearance2.Forecolor = System.Drawing.Color.Empty;
            inputAppearance2.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            inputAppearance2.TextPlaceholder = "Username";
            this.txtUser.Style = inputAppearance2;
            this.txtUser.TabIndex = 0;
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.txtPassword.Location = new System.Drawing.Point(155, 327);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(283, 22);
            inputAppearance3.ActiveBackcolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            inputAppearance3.ActiveForecolor = System.Drawing.Color.Gray;
            inputAppearance3.BorderActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            inputAppearance3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            inputAppearance3.BorderPadding = 9;
            inputAppearance3.BorderRadius = 5;
            inputAppearance3.BorderSize = 1;
            inputAppearance3.Draw = PuntoDeVentas.InputAppearance.DrawStyle.Both;
            inputAppearance3.Forecolor = System.Drawing.Color.Empty;
            inputAppearance3.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            inputAppearance3.TextPlaceholder = "Password";
            this.txtPassword.Style = inputAppearance3;
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // inputTextBox1
            // 
            this.inputTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.inputTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputTextBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.inputTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.inputTextBox1.Location = new System.Drawing.Point(225, 14);
            this.inputTextBox1.Name = "inputTextBox1";
            this.inputTextBox1.Size = new System.Drawing.Size(283, 22);
            inputAppearance1.ActiveBackcolor = System.Drawing.Color.Silver;
            inputAppearance1.ActiveForecolor = System.Drawing.Color.Gray;
            inputAppearance1.BorderActiveColor = System.Drawing.Color.Silver;
            inputAppearance1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            inputAppearance1.BorderPadding = 9;
            inputAppearance1.BorderRadius = 5;
            inputAppearance1.BorderSize = 1;
            inputAppearance1.Draw = PuntoDeVentas.InputAppearance.DrawStyle.Fill;
            inputAppearance1.Forecolor = System.Drawing.Color.Empty;
            inputAppearance1.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            inputAppearance1.TextPlaceholder = "Username";
            this.inputTextBox1.Style = inputAppearance1;
            this.inputTextBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.label1.Location = new System.Drawing.Point(234, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 45);
            this.label1.TabIndex = 33;
            this.label1.Text = "ShopySale";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PuntoDeVentas.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(146, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblErrorMsg.Image = global::PuntoDeVentas.Properties.Resources.SmallFlag;
            this.lblErrorMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorMsg.Location = new System.Drawing.Point(151, 409);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(287, 43);
            this.lblErrorMsg.TabIndex = 31;
            this.lblErrorMsg.Text = "[ERROR MESSAGE]";
            this.lblErrorMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorMsg.Visible = false;
            // 
            // FRM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PuntoDeVentas.Properties.Resources.Bg1;
            this.ClientSize = new System.Drawing.Size(584, 548);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblErrorMsg);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Login";
            this.ShowTitleLabel = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Login";
            this.WindowBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(142)))), ((int)(((byte)(57)))));
            this.Load += new System.EventHandler(this.FRM_Login_Load);
            this.Controls.SetChildIndex(this.lblErrorMsg, 0);
            this.Controls.SetChildIndex(this.txtUser, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.lblWndPanelTitle, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.lblWndPanelTitle.ResumeLayout(false);
            this.lblWndPanelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrorMsg;
        private Controls.InputTextBox txtUser;
        private Controls.InputTextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.InputTextBox inputTextBox1;
        private System.Windows.Forms.Label label1;
    }
}

