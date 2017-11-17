namespace PuntoDeVentas {
    partial class FRM_ACCESS_LOGIN {
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
            PuntoDeVentas.InputAppearance inputAppearance1 = new PuntoDeVentas.InputAppearance();
            PuntoDeVentas.InputAppearance inputAppearance2 = new PuntoDeVentas.InputAppearance();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new PuntoDeVentas.Controls.InputTextBox();
            this.txtPassword = new PuntoDeVentas.Controls.InputTextBox();
            this.SuspendLayout();
            // 
            // lblWndPanelTitle
            // 
            this.lblWndPanelTitle.Size = new System.Drawing.Size(500, 58);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.label2.Image = global::PuntoDeVentas.Properties.Resources.lock__2_;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(16, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 81);
            this.label2.TabIndex = 2;
            this.label2.Text = "Acceso solo para Adminstradores";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.txtUser.Location = new System.Drawing.Point(118, 118);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(301, 25);
            inputAppearance1.ActiveBackcolor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            inputAppearance1.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            inputAppearance1.BorderActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            inputAppearance1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            inputAppearance1.BorderPadding = 7;
            inputAppearance1.BorderRadius = 7;
            inputAppearance1.BorderSize = 1;
            inputAppearance1.Draw = PuntoDeVentas.InputAppearance.DrawStyle.Fill;
            inputAppearance1.Forecolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            inputAppearance1.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            inputAppearance1.TextPlaceholder = "Usuario";
            this.txtUser.Style = inputAppearance1;
            this.txtUser.TabIndex = 38;
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.txtPassword.Location = new System.Drawing.Point(119, 182);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(301, 25);
            inputAppearance2.ActiveBackcolor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            inputAppearance2.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            inputAppearance2.BorderActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            inputAppearance2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            inputAppearance2.BorderPadding = 7;
            inputAppearance2.BorderRadius = 7;
            inputAppearance2.BorderSize = 1;
            inputAppearance2.Draw = PuntoDeVentas.InputAppearance.DrawStyle.Fill;
            inputAppearance2.Forecolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(117)))), ((int)(((byte)(131)))));
            inputAppearance2.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            inputAppearance2.TextPlaceholder = "Password";
            this.txtPassword.Style = inputAppearance2;
            this.txtPassword.TabIndex = 39;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // FRM_ACCESS_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 265);
            this.ControlBox = false;
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.KeyPreview = true;
            this.Name = "FRM_ACCESS_LOGIN";
            this.ShowTitleLabel = false;
            this.Text = "FRM_ACCESS_LOGIN";
            this.WindowBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FRM_ACCESS_LOGIN_KeyDown);
            this.Controls.SetChildIndex(this.lblWndPanelTitle, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtUser, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Controls.InputTextBox txtUser;
        private Controls.InputTextBox txtPassword;
    }
}