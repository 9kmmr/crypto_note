using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoCoin
{
    public partial class Splashscreen : Form
    {
        public Checkenter thisenter;
        public Splashscreen(Checkenter checkenter)
        {
            thisenter = checkenter;
            InitializeComponent();
        }
        //Use timer class
        Timer tmr;
        private void Splashscreen_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            //set time interval 2 sec
            tmr.Interval = 2000;
            //starts the timer
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }
        void tmr_Tick(object sender, EventArgs e)
        {
            //after 2 sec stop the timer
            tmr.Stop();
            //display mainform
            Form1 mf = new Form1(thisenter);
            mf.Show();
            //hide this form
            this.Hide();
        }
    }
}
