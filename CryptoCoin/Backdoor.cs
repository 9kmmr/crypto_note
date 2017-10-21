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
    public partial class Backdoor : Form
    {
        public Checkenter isenter;
        public Backdoor(Checkenter enter)
        {
            InitializeComponent();
            isenter = enter;
        }
        // CLICK THE BACK BUTTON
        private void backpass_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // ENTER THE BACKDOOR TO CHANGE PASSWORD EVENT
        private void backdoorenter_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please type a strong password !");
            }
            else
            {
                if (isenter.firstsecond(textBox1.Text))
                {
                    new Passchange(isenter).ShowDialog();
                   
                    textBox1.Text = "";
                }
                else
                {
                    if (isenter.checkEnter(textBox1.Text, "secondary"))
                    {
                        new Passchange(isenter).ShowDialog();
                       
                        textBox1.Text = "";
                    }
                    else MessageBox.Show("Wrong password ! \r\n Please try again.");
                }
            }
            isenter.is_firstentersec = false;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextBox TB = (TextBox)sender;
            int VisibleTime = 10000;  //in milliseconds

            ToolTip tt = new ToolTip();
            if (isenter.is_firstentersec)
                tt.Show("Enter your first secondary password", TB, 200, 0, VisibleTime);
        }
    }
}
