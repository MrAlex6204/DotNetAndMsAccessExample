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
            PuntoDeVentas.InputAppearance inputAppearance1 = new PuntoDeVentas.InputAppearance();
            PuntoDeVentas.InputAppearance inputAppearance2 = new PuntoDeVentas.InputAppearance();
            this.label3 = new System.Windows.Forms.Label();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.txtUser = new PuntoDeVentas.Controls.InputTextBox();
            this.txtPassword = new PuntoDeVentas.Controls.InputTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWndPanelTitle
            // 
            this.lblWndPanelTitle.Size = new System.Drawing.Size(443, 51);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label3.Location = new System.Drawing.Point(164, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 45);
            this.label3.TabIndex = 29;
            this.label3.Text = "Log In";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblErrorMsg.Image = global::PuntoDeVentas.Properties.Resources.SmallFlag;
            this.lblErrorMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorMsg.Location = new System.Drawing.Point(65, 351);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(300, 43);
            this.lblErrorMsg.TabIndex = 31;
            this.lblErrorMsg.Text = "[ERROR MESSAGE]";
            this.lblErrorMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorMsg.Visible = false;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.Window;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.txtUser.Location = new System.Drawing.Point(82, 212);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(283, 22);
            inputAppearance1.ActiveBackcolor = System.Drawing.Color.Silver;
            inputAppearance1.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            inputAppearance1.BorderActiveColor = System.Drawing.Color.Silver;
            inputAppearance1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            inputAppearance1.BorderPadding = 7;
            inputAppearance1.BorderSize = 1;
            inputAppearance1.Draw = PuntoDeVentas.InputAppearance.DrawStyle.Line;
            inputAppearance1.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            inputAppearance1.TextPlaceholder = "Username";
            this.txtUser.Style = inputAppearance1;
            this.txtUser.TabIndex = 0;
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.txtPassword.Location = new System.Drawing.Point(82, 270);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(283, 22);
            inputAppearance2.ActiveBackcolor = System.Drawing.Color.Empty;
            inputAppearance2.ActiveForecolor = System.Drawing.Color.Silver;
            inputAppearance2.BorderActiveColor = System.Drawing.Color.Silver;
            inputAppearance2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            inputAppearance2.BorderPadding = 7;
            inputAppearance2.BorderSize = 1;
            inputAppearance2.Draw = PuntoDeVentas.InputAppearance.DrawStyle.Line;
            inputAppearance2.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            inputAppearance2.TextPlaceholder = "Password";
            this.txtPassword.Style = inputAppearance2;
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblTitle.Location = new System.Drawing.Point(6, 8);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(435, 78);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "[EMPRESA]";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FRM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 422);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.lblTitle);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Login";
            this.ShowTitleLabel = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Login";
            this.WindowBorderColor = System.Drawing.Color.WhiteSmoke;
            this.Load += new System.EventHandler(this.FRM_Login_Load);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.lblWndPanelTitle, 0);
            this.Controls.SetChildIndex(this.lblErrorMsg, 0);
            this.Controls.SetChildIndex(this.txtUser, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblErrorMsg;
        private Controls.InputTextBox txtUser;
        private Controls.InputTextBox txtPassword;
        private System.Windows.Forms.Label lblTitle;
    }
}

