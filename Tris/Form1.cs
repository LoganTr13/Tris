using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;

namespace Tris
{
    public partial class Tris : Form
    {
        bool modoNoturno = true;        
        public Tris()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModoNoturno_Click(object sender, EventArgs e)
        {
            if (modoNoturno)
            {
                LightMode();
                modoNoturno = false;
            }
            else
            {
                DarkMode();
                modoNoturno = true;
            }
        }
        void DarkMode()
        {
            BackColor = Color.FromArgb(25, 20, 33);
            pnFunctions.BackColor = Color.FromArgb(1, 21, 47);
            pnApps.BackColor = Color.FromArgb(25, 27, 37);

            btnCima.BackColor = Color.FromArgb(27, 26, 42);
            btnBaixo.BackColor = Color.FromArgb(27, 26, 42);

            this.cpbCPU.ForeColor = Color.FromArgb(220, 185, 250);
            this.cpbRAM.ForeColor = Color.FromArgb(220, 185, 250);
            this.cpbDISK.ForeColor = Color.FromArgb(220, 185, 250);

            this.cpbCPU.OuterColor = Color.FromArgb(65, 65, 123);
            this.cpbRAM.OuterColor = Color.FromArgb(65, 65, 123);
            this.cpbDISK.OuterColor = Color.FromArgb(65, 65, 123);

            this.cpbCPU.ProgressColor = Color.FromArgb(37, 154, 195);
            this.cpbRAM.ProgressColor = Color.FromArgb(37, 154, 195);
            this.cpbDISK.ProgressColor = Color.FromArgb(37, 154, 195);

            lblCPU.ForeColor = Color.FromArgb(13, 36, 87);
            lblRAM.ForeColor = Color.FromArgb(13, 36, 87);
            lblDisk.ForeColor = Color.FromArgb(13, 36, 87);
        }
        void LightMode() 
        {
            BackColor = Color.FromArgb(238, 247, 255);
            pnFunctions.BackColor = Color.FromArgb(240, 220, 245);
            pnApps.BackColor = Color.FromArgb(200, 220, 255);

            btnCima.BackColor = Color.FromArgb(200, 200, 255);
            btnBaixo.BackColor = Color.FromArgb(200, 200, 255);

            this.cpbCPU.ForeColor = Color.FromArgb(220, 185, 250);
            this.cpbRAM.ForeColor = Color.FromArgb(220, 185, 250);
            this.cpbDISK.ForeColor = Color.FromArgb(220, 185, 250);

            this.cpbCPU.OuterColor = Color.FromArgb(186, 224, 255);
            this.cpbRAM.OuterColor = Color.FromArgb(186, 224, 255);
            this.cpbDISK.OuterColor = Color.FromArgb(186, 224, 255);

            this.cpbCPU.ProgressColor = Color.FromArgb(190, 255, 252);
            this.cpbRAM.ProgressColor = Color.FromArgb(190, 255, 252);
            this.cpbDISK.ProgressColor = Color.FromArgb(190, 255, 252);

            lblCPU.ForeColor = Color.FromArgb(220, 200, 255);
            lblRAM.ForeColor = Color.FromArgb(220, 200, 255);
            lblDisk.ForeColor = Color.FromArgb(220, 200, 255);
        }
    }
}
