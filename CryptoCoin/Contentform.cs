using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Linq;
using System.Security.Cryptography;

namespace CryptoCoin
{
    public partial class Contentform : Form
    {
        public Checkenter isenter;
        public cryptdata newencrypt = new cryptdata();
        public Contentform(Checkenter thisenter)
        {
            InitializeComponent();
            isenter = thisenter;
            datachange();
        }
        // if data change
        public void datachange()
        {
            List<string> dataall = isenter.getdatafile();
            List<contents> alldat = deserialdata(dataall);
            
           
            int i = 2;
            List<Control> listControls = flowLayoutPanel1.Controls.Cast<Control>().ToList();

            foreach (Control control in listControls)
            {
                flowLayoutPanel1.Controls.Remove(control);
                control.Dispose();
            }
            
            foreach (var item in alldat)
            {
                
                try
                {
                    item.name = newencrypt.DecryptStringAES(item.name, "lamvu");
                    item.currency = newencrypt.DecryptStringAES(item.currency, "lamvu");
                    item.publicaddress = newencrypt.DecryptStringAES(item.publicaddress, "lamvu");
                    item.privateaddress = newencrypt.DecryptStringAES(item.privateaddress, "lamvu");
                    item.notes = newencrypt.DecryptStringAES(item.notes, "lamvu");                   
                }
                catch (Exception)
                {  
                }
                Detailscontent dt = new Detailscontent(item, ++i);
                var destailbtn = new Button();
                destailbtn.Text = "*";
                destailbtn.Height = 25;
                destailbtn.FlatStyle = FlatStyle.Flat;
                destailbtn.Click += (s, e) => {
                    dt.ShowDialog();
                    isenter.loadData();
                    datachange();
                };
                Label num1 = new Label();
                num1.Text = (i - 2) + ".";
                num1.TextAlign = ContentAlignment.BottomCenter;
                num1.AutoSize = true;

                var btnpublic = new Button();
                btnpublic.Text = ">";
                btnpublic.TextAlign = ContentAlignment.TopCenter;
                btnpublic.Height = 25;
                btnpublic.FlatStyle = FlatStyle.Flat;
                btnpublic.Click += (s, e) => {
                    MessageBox.Show("Public Address : " + item.publicaddress);
                };

                var btnprivate = new Button();
                btnprivate.Text = ">";
                btnprivate.TextAlign = ContentAlignment.TopCenter;
                btnprivate.Height = 25;
                btnprivate.FlatStyle = FlatStyle.Flat;
                btnprivate.Click += (s, e) => {
                    MessageBox.Show("Private Address : " + item.privateaddress);
                };

                TextBox nametx = new TextBox();
                nametx.Width = 160;
                nametx.ReadOnly = true;
                nametx.Text = item.name;
                TextBox currtx = new TextBox();
                currtx.Text = item.currency;
                currtx.ReadOnly = true;


                // add content to panel

                flowLayoutPanel1.Controls.Add(destailbtn);
                flowLayoutPanel1.Controls.Add(num1);
                flowLayoutPanel1.Controls.Add(nametx);
                flowLayoutPanel1.Controls.Add(currtx);
                flowLayoutPanel1.Controls.Add(btnpublic);
                flowLayoutPanel1.Controls.Add(btnprivate);

            }
        }
        
        // DESERIAL DATA FROM JSON TO OBJECT
        public List<contents> deserialdata(List<string>  dataall)
        {
            List<contents> allcontents = new List<contents>();
            foreach (var item in dataall)
            {
                if (item != "")
                {
                    try
                    {
                        contents newcontents = JsonConvert.DeserializeObject<contents>(item);
                        allcontents.Add(newcontents);
                    }
                    catch (Exception)
                    {

                       
                    }
                    
                }
            }
            return allcontents;
           
        }

        // CLOSE PROGRAM
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // EVENT TRIGGER BEFORE FORM CLOSE
        private void Contentform_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show(e.CloseReason.ToString());
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                return;
            }


            var result = MessageBox.Show("Do you want to exit ?", "Confirm exit",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

            if ((result == DialogResult.No))
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }
        // ADD NEW CONTENTS AND REFRESH DATA
        private void button2_Click(object sender, EventArgs e)
        {
            
            new Addcontents(isenter).ShowDialog();
            isenter.loadData();
            datachange();

        }
        // OPEN BACKDOOR TO CHANGE PASSWORD
        private void button1_Click(object sender, EventArgs e)
        {            
            new Backdoor(isenter).ShowDialog();
            isenter.loadData();
            datachange();
        }
    }
}
