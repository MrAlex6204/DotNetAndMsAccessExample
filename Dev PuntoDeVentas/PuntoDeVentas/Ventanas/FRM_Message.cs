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
    public partial class FRM_Message : Form
    {
        public FRM_Message()
        {
            InitializeComponent();
        }

        private void TRM_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Message_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) {
                this.Close();
            }
        }
        public string Message {
            set {
                lblMessage.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
    public partial class FRM_Message : Form
    {
        public FRM_Message()
        {
            InitializeComponent();
        }

        private void TRM_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Message_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) {
                this.Close();
            }
        }
        public string Message {
            set {
                lblMessage.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
    public partial class FRM_Message : Form
    {
        public FRM_Message()
        {
            InitializeComponent();
        }

        private void TRM_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Message_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) {
                this.Close();
            }
        }
        public string Message {
            set {
                lblMessage.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
>>>>>>> 208d285bee0af146f9f98d8836b287fa0df48b6b
