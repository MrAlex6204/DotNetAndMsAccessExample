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
    public partial class FRM_Config : Form
    {
        public FRM_Config()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea guardar los cambio?", "Configuracion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.PuntoDeVentas.UpdateConfig("EMPRESA", txtEmpresa.Text.Trim());
                Funciones.Message("La configuracion se guardo exitosamente!");
            }            
        }

        private void FRM_Config_Load(object sender, EventArgs e)
        {
            txtEmpresa.Text = System.PuntoDeVentas.GetConfig("EMPRESA");
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
    public partial class FRM_Config : Form
    {
        public FRM_Config()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea guardar los cambio?", "Configuracion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.PuntoDeVentas.UpdateConfig("EMPRESA", txtEmpresa.Text.Trim());
                Funciones.Message("La configuracion se guardo exitosamente!");
            }            
        }

        private void FRM_Config_Load(object sender, EventArgs e)
        {
            txtEmpresa.Text = System.PuntoDeVentas.GetConfig("EMPRESA");
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
    public partial class FRM_Config : Form
    {
        public FRM_Config()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea guardar los cambio?", "Configuracion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.PuntoDeVentas.UpdateConfig("EMPRESA", txtEmpresa.Text.Trim());
                Funciones.Message("La configuracion se guardo exitosamente!");
            }            
        }

        private void FRM_Config_Load(object sender, EventArgs e)
        {
            txtEmpresa.Text = System.PuntoDeVentas.GetConfig("EMPRESA");
        }
    }
}
>>>>>>> 208d285bee0af146f9f98d8836b287fa0df48b6b
