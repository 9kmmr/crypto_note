using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoCoin
{
    public partial class Form1 : Form
    {

        public bool UserClosing { get; set; }
        public Checkenter isenter;
        string hintpath = Path.GetDirectoryName(Application.ExecutablePath) + "/HintData.DAT";

        int countenter = 1;

        public Form1(Checkenter checkenterthis)
        {
            UserClosing = false;
            InitializeComponent();
            isenter = checkenterthis;
            // receiver the hint value
            hintval.Text = "Hint : "+ File.ReadAllText(hintpath);

        }
       
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //exit application when form is closed
            Application.Exit();
        }

       

        private void exit_Click(object sender, EventArgs e)
        {
            UserClosing = true;
            this.Close();
        }
        // EVENT 
        private void enter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please type a strong password");
            }
            else
            {
                if (isenter.firstenter(textBox1.Text))
                {
                    this.Hide();
                    new Contentform(isenter).Show();
                }
                else
                {
                    if (isenter.checkEnter(textBox1.Text, "primary"))
                    {
                        this.Hide();
                        new Contentform(isenter).Show();
                    }
                    else MessageBox.Show("Wrong password ! \r\n Please try again.");
                }
                countenter++;
                if (countenter == 4) Application.Exit();
            }

        }
        // EVENT OPEN THE BACKDOOR
        private void passchange_Click(object sender, EventArgs e)
        {
            Backdoor bd = new Backdoor(isenter);
            this.Hide();
            bd.ShowDialog();
            this.Show();

        }
        // EVENT TRIGGER BEFORE CLOSE FORM
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            switch (e.CloseReason)
            {
                case CloseReason.ApplicationExitCall:

                    break;
                case CloseReason.FormOwnerClosing:
                    break;
                case CloseReason.MdiFormClosing:
                    break;
                case CloseReason.None:
                    break;
                case CloseReason.TaskManagerClosing:
                    break;
                case CloseReason.UserClosing:
                    if (UserClosing)
                    {
                        var result = MessageBox.Show("Do you want to exit ?", "Confirm exit",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                        if ((result == DialogResult.Yes))
                        {
                            Application.Exit();                            
                        }
                        else
                        {
                            e.Cancel = true;
                        }
                    }
                    else
                    {
                        //what should happen if the user hitted the x in the upper right corner?
                    }
                    break;
                case CloseReason.WindowsShutDown:
                    break;
                default:
                    break;
            }
            UserClosing = false;
           
        }
        

        private void textBox1_Enter(object sender, EventArgs e)
        {

            TextBox TB = (TextBox)sender;
            int VisibleTime = 10000;  //in milliseconds

            ToolTip tt = new ToolTip();
            if (isenter.is_firstenterpri)
            tt.Show("Enter your first primary password", TB, 250, 0, VisibleTime);
        }
    }
}
