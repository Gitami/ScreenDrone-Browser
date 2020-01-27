using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace PanelBrowser
{
    public partial class Splash : Form
    {

        int loadbarvalue = 0;

        public Splash()
        {
            InitializeComponent();
            Bitmap b = new Bitmap(this.BackgroundImage);
            b.MakeTransparent(b.GetPixel(1, 1));
            this.BackgroundImage = b;
        }


        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (loadbarvalue <= 90)
            {
                loadbarvalue = loadbarvalue + 10;
                splashloadbar.Value = loadbarvalue;
            }
        }
    }
}
