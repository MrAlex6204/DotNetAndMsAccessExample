<<<<<<< HEAD
<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuntoDeVentas
{
    public partial class FRM_Login : Form
    {

        private bool _bUserIsLogged = false;

        
        public bool UserIsLoggued {
            get {
                return _bUserIsLogged;
            }
        }

        public FRM_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validar user y password
            if (System.PuntoDeVentas.ValidarUsuario(txtUsuario.Text.Trim(), txtPassword.Text.Trim()))
            {
                Funciones.Message("BIENVENIDO! "+System.PuntoDeVentas.Nombre.ToUpper());
                _bUserIsLogged = true;
                this.Close();
            }
            else
            {
                _bUserIsLogged = false;
                MessageBox.Show("Usuario Invalido!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Cerrar applicacion
            Application.Exit();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                txtPassword.Focus();
            }

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                button1.Focus();
            }
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuntoDeVentas
{
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (System.PuntoDeVentas.ValidarUsuario(txtUsuario.Text.Trim(), txtPassword.Text.Trim()))
            {
                Funciones.Message("BIENVENIDO! "+System.PuntoDeVentas.Nombre.ToUpper());
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario Invalido!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                txtPassword.Focus();
            }

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                button1.Focus();
            }
        }
    }
}
>>>>>>> 208d285bee0af146f9f98d8836b287fa0df48b6b
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuntoDeVentas
{
    public partial class FRM_Login : Form
    {
        public FRM_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (System.PuntoDeVentas.ValidarUsuario(txtUsuario.Text.Trim(), txtPassword.Text.Trim()))
            {
                Funciones.Message("BIENVENIDO! "+System.PuntoDeVentas.Nombre.ToUpper());
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario Invalido!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                txtPassword.Focus();
            }

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                button1.Focus();
            }
        }
    }
}
>>>>>>> 208d285bee0af146f9f98d8836b287fa0df48b6b
