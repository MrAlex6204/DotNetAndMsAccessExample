<<<<<<< HEAD
<<<<<<< HEAD
﻿namespace PuntoDeVentas
{
    partial class FRM_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Usuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdioAdmin = new System.Windows.Forms.RadioButton();
            this.rdioUsuario = new System.Windows.Forms.RadioButton();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmdLocalizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(181, 14);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(221, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(181, 44);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(181, 74);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(132, 22);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(181, 104);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(132, 22);
            this.txtConfirmPassword.TabIndex = 6;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txtConfirmPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmPassword_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdioAdmin);
            this.groupBox1.Controls.Add(this.rdioUsuario);
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 86);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nivel de permiso";
            // 
            // rdioAdmin
            // 
            this.rdioAdmin.AutoSize = true;
            this.rdioAdmin.Location = new System.Drawing.Point(272, 38);
            this.rdioAdmin.Name = "rdioAdmin";
            this.rdioAdmin.Size = new System.Drawing.Size(109, 20);
            this.rdioAdmin.TabIndex = 3;
            this.rdioAdmin.TabStop = true;
            this.rdioAdmin.Text = "Administrador";
            this.rdioAdmin.UseVisualStyleBackColor = true;
            // 
            // rdioUsuario
            // 
            this.rdioUsuario.AutoSize = true;
            this.rdioUsuario.Location = new System.Drawing.Point(107, 38);
            this.rdioUsuario.Name = "rdioUsuario";
            this.rdioUsuario.Size = new System.Drawing.Size(116, 20);
            this.rdioUsuario.TabIndex = 2;
            this.rdioUsuario.TabStop = true;
            this.rdioUsuario.Text = "Usuario Cajero";
            this.rdioUsuario.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            this.cmdCancel.AutoSize = true;
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Location = new System.Drawing.Point(267, 265);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(80, 26);
            this.cmdCancel.TabIndex = 8;
            this.cmdCancel.Text = "Cancelar";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.AutoSize = true;
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(171, 265);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 26);
            this.cmdGuardar.TabIndex = 9;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha";
            // 
            // lblFecha
            // 
            this.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFecha.Location = new System.Drawing.Point(178, 134);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(224, 22);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdLocalizar
            // 
            this.cmdLocalizar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLocalizar.Location = new System.Drawing.Point(409, 14);
            this.cmdLocalizar.Name = "cmdLocalizar";
            this.cmdLocalizar.Size = new System.Drawing.Size(36, 23);
            this.cmdLocalizar.TabIndex = 12;
            this.cmdLocalizar.Text = "...";
            this.cmdLocalizar.UseVisualStyleBackColor = true;
            this.cmdLocalizar.Click += new System.EventHandler(this.cmdLocalizar_Click);
            // 
            // FRM_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 310);
            this.Controls.Add(this.cmdLocalizar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Usuarios";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FRM_Usuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.RadioButton rdioAdmin;
        private System.Windows.Forms.RadioButton rdioUsuario;
        private System.Windows.Forms.Button cmdLocalizar;
    }
=======
﻿namespace PuntoDeVentas
{
    partial class FRM_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Usuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdioAdmin = new System.Windows.Forms.RadioButton();
            this.rdioUsuario = new System.Windows.Forms.RadioButton();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmdLocalizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(181, 14);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(221, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(181, 44);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(181, 74);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(132, 22);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(181, 104);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(132, 22);
            this.txtConfirmPassword.TabIndex = 6;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txtConfirmPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmPassword_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdioAdmin);
            this.groupBox1.Controls.Add(this.rdioUsuario);
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 86);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nivel";
            // 
            // rdioAdmin
            // 
            this.rdioAdmin.AutoSize = true;
            this.rdioAdmin.Location = new System.Drawing.Point(272, 38);
            this.rdioAdmin.Name = "rdioAdmin";
            this.rdioAdmin.Size = new System.Drawing.Size(109, 20);
            this.rdioAdmin.TabIndex = 3;
            this.rdioAdmin.TabStop = true;
            this.rdioAdmin.Text = "Administrador";
            this.rdioAdmin.UseVisualStyleBackColor = true;
            // 
            // rdioUsuario
            // 
            this.rdioUsuario.AutoSize = true;
            this.rdioUsuario.Location = new System.Drawing.Point(107, 38);
            this.rdioUsuario.Name = "rdioUsuario";
            this.rdioUsuario.Size = new System.Drawing.Size(73, 20);
            this.rdioUsuario.TabIndex = 2;
            this.rdioUsuario.TabStop = true;
            this.rdioUsuario.Text = "Usuario";
            this.rdioUsuario.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            this.cmdCancel.AutoSize = true;
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Location = new System.Drawing.Point(267, 265);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(80, 26);
            this.cmdCancel.TabIndex = 8;
            this.cmdCancel.Text = "Cancelar";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.AutoSize = true;
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(171, 265);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 26);
            this.cmdGuardar.TabIndex = 9;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha";
            // 
            // lblFecha
            // 
            this.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFecha.Location = new System.Drawing.Point(178, 134);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(224, 22);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdLocalizar
            // 
            this.cmdLocalizar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLocalizar.Location = new System.Drawing.Point(409, 14);
            this.cmdLocalizar.Name = "cmdLocalizar";
            this.cmdLocalizar.Size = new System.Drawing.Size(36, 23);
            this.cmdLocalizar.TabIndex = 12;
            this.cmdLocalizar.Text = "...";
            this.cmdLocalizar.UseVisualStyleBackColor = true;
            this.cmdLocalizar.Click += new System.EventHandler(this.cmdLocalizar_Click);
            // 
            // FRM_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 310);
            this.Controls.Add(this.cmdLocalizar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Usuarios";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FRM_Usuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.RadioButton rdioAdmin;
        private System.Windows.Forms.RadioButton rdioUsuario;
        private System.Windows.Forms.Button cmdLocalizar;
    }
>>>>>>> 208d285bee0af146f9f98d8836b287fa0df48b6b
=======
﻿namespace PuntoDeVentas
{
    partial class FRM_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Usuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdioAdmin = new System.Windows.Forms.RadioButton();
            this.rdioUsuario = new System.Windows.Forms.RadioButton();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmdLocalizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(181, 14);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(221, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(181, 44);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(181, 74);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(132, 22);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(181, 104);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(132, 22);
            this.txtConfirmPassword.TabIndex = 6;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txtConfirmPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmPassword_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdioAdmin);
            this.groupBox1.Controls.Add(this.rdioUsuario);
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 86);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nivel";
            // 
            // rdioAdmin
            // 
            this.rdioAdmin.AutoSize = true;
            this.rdioAdmin.Location = new System.Drawing.Point(272, 38);
            this.rdioAdmin.Name = "rdioAdmin";
            this.rdioAdmin.Size = new System.Drawing.Size(109, 20);
            this.rdioAdmin.TabIndex = 3;
            this.rdioAdmin.TabStop = true;
            this.rdioAdmin.Text = "Administrador";
            this.rdioAdmin.UseVisualStyleBackColor = true;
            // 
            // rdioUsuario
            // 
            this.rdioUsuario.AutoSize = true;
            this.rdioUsuario.Location = new System.Drawing.Point(107, 38);
            this.rdioUsuario.Name = "rdioUsuario";
            this.rdioUsuario.Size = new System.Drawing.Size(73, 20);
            this.rdioUsuario.TabIndex = 2;
            this.rdioUsuario.TabStop = true;
            this.rdioUsuario.Text = "Usuario";
            this.rdioUsuario.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            this.cmdCancel.AutoSize = true;
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Location = new System.Drawing.Point(267, 265);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(80, 26);
            this.cmdCancel.TabIndex = 8;
            this.cmdCancel.Text = "Cancelar";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.AutoSize = true;
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(171, 265);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 26);
            this.cmdGuardar.TabIndex = 9;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha";
            // 
            // lblFecha
            // 
            this.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFecha.Location = new System.Drawing.Point(178, 134);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(224, 22);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdLocalizar
            // 
            this.cmdLocalizar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLocalizar.Location = new System.Drawing.Point(409, 14);
            this.cmdLocalizar.Name = "cmdLocalizar";
            this.cmdLocalizar.Size = new System.Drawing.Size(36, 23);
            this.cmdLocalizar.TabIndex = 12;
            this.cmdLocalizar.Text = "...";
            this.cmdLocalizar.UseVisualStyleBackColor = true;
            this.cmdLocalizar.Click += new System.EventHandler(this.cmdLocalizar_Click);
            // 
            // FRM_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 310);
            this.Controls.Add(this.cmdLocalizar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Usuarios";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FRM_Usuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.RadioButton rdioAdmin;
        private System.Windows.Forms.RadioButton rdioUsuario;
        private System.Windows.Forms.Button cmdLocalizar;
    }
>>>>>>> 208d285bee0af146f9f98d8836b287fa0df48b6b
}