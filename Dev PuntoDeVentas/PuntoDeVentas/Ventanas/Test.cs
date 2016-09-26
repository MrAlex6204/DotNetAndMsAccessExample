using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentas {
    public class Test : Controls.BaseForm {
        private Controls.WindowControlBox windowControlBox1;

        public Test() {
            InitializeComponent();
        }

        private void InitializeComponent() {
            PuntoDeVentas.Controls.ControlAppearance controlAppearance1 = new PuntoDeVentas.Controls.ControlAppearance();
            this.windowControlBox1 = new PuntoDeVentas.Controls.WindowControlBox();
            this.SuspendLayout();
            // 
            // windowControlBox1
            // 
            controlAppearance1.BorderColor = System.Drawing.Color.Empty;
            controlAppearance1.BorderSize = 0;
            controlAppearance1.CheckedBackColor = System.Drawing.Color.Empty;
            controlAppearance1.Forecolor = System.Drawing.Color.Green;
            controlAppearance1.MouseDownBackColor = System.Drawing.Color.Empty;
            controlAppearance1.MouseOverBackColor = System.Drawing.Color.Empty;
            this.windowControlBox1.Appearance = controlAppearance1;
            this.windowControlBox1.AutoSize = true;
            this.windowControlBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.windowControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.windowControlBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.windowControlBox1.Location = new System.Drawing.Point(387, 156);
            this.windowControlBox1.Name = "windowControlBox1";
            this.windowControlBox1.Size = new System.Drawing.Size(159, 36);
            this.windowControlBox1.TabIndex = 1;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.ClientSize = new System.Drawing.Size(911, 364);
            this.Controls.Add(this.windowControlBox1);
            this.Name = "Test";
            this.Controls.SetChildIndex(this.lblWndPanelTitle, 0);
            this.Controls.SetChildIndex(this.windowControlBox1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
