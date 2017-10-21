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
using Newtonsoft.Json;
using System.Security.Cryptography;

namespace CryptoCoin
{ 
    public partial class Detailscontent : Form
    {
        public contents thiscontent;
        int index = 0;
        // LOADING DATA FROM MAIN PROGRAM
        public Detailscontent(contents details,int index_data)
        {
            InitializeComponent();
            thiscontent = details;
            index = index_data;
            nametxt.Text = thiscontent.name;
            currencytxt.Text = thiscontent.currency;
            publictxt.Text = thiscontent.publicaddress;
            privatetxt.Text = thiscontent.privateaddress;
            notetxt.Text = thiscontent.notes;
        }


        /**
         * EXIT TO THE MAIN PROGRAM
         * **/
        private void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to Save ?", "Confirm Save",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question);

            if ((result == DialogResult.No))
            {
                // no just close this
                this.Close();
            }
            else
            {
                // yes we save
                if (checkvalid(nametxt) && checkvalid(currencytxt) && checkvalid(publictxt) && checkvalid(privatetxt))
                {
                    Update();
                    this.Close();
                }
                else { MessageBox.Show("Update Failed!"); }

            }

           
        }
        // UPDATE VALUES BY ROWS IN FILE
        private void Update()
        {
            Checkenter checkenter = new Checkenter();
            thiscontent.name = nametxt.Text;
            thiscontent.currency = currencytxt.Text;
            thiscontent.publicaddress = publictxt.Text;
            thiscontent.privateaddress = privatetxt.Text;
            thiscontent.notes = notetxt.Text;
            string json = JsonConvert.SerializeObject(thiscontent);
            checkenter.lineChanger(json, checkenter.path, index);
            
        }
        // DELETE BUTTON AND CONFIRM
        private void btndelete_Click(object sender, EventArgs e)
        {
            Checkenter checkenter = new Checkenter();
            checkenter.loadData();
            Prompt prompt = new Prompt();
            prompt.ShowDialog("Enter your Primary Password to confirm : ", "Confirm Delete ?");
            string promptValue = prompt.Closedialog();
            if (promptValue != "")
            {
                using (MD5 md5Hash = MD5.Create())
                {
                    if (checkenter.VerifyMd5Hash(md5Hash, promptValue, checkenter.primarypass))
                    {
                        checkenter.lineChanger("", checkenter.path, index);
                        File.WriteAllLines(checkenter.path, File.ReadLines(checkenter.path).Where(l => l != "").ToList());
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password! \n Delete Failed.");
                    }
                }
            }
            
        }
        // update content
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (checkvalid(nametxt)&& checkvalid(currencytxt)&& checkvalid(publictxt)&& checkvalid(privatetxt))
            {
                Update();
                this.Close();
            }else { MessageBox.Show("Update Failed!"); }
        }
        public Boolean checkvalid(TextBox textbox)
        {
            Boolean ischeckempty = true;
            if (string.IsNullOrWhiteSpace(textbox.Text))
            {
                errorProvider1.SetError(textbox, "This field cant be empty!");
                ischeckempty = false;
            }
            else { errorProvider1.Clear(); }
            
            return ischeckempty;

        }
    }
    // THIS CLASS CREATE NEW CUSTOM DIALOG INPUT PASSWORD TO DELETE
    public  class Prompt
    {
        public Form prompt = new Form();
         TextBox inputBox = new TextBox() { Left = 50, Top = 60, Width = 200 };
        
        public  void ShowDialog(string text, string caption)
        {
            prompt.MinimizeBox = false;
            prompt.MaximizeBox = false;
            prompt.ControlBox = false;
            prompt.StartPosition = FormStartPosition.CenterParent;
            prompt.Width = 300;
            prompt.Height = 200;
            prompt.Text = caption;
            Label textLabel = new Label() { Left = 30, Top = 20,Width=200, Text = text };
            inputBox.UseSystemPasswordChar = true;
            Button confirmation = new Button() { Text = "DELETE", Left = 80, Width = 70, Top = 120,Height=30 };
            confirmation.Click += (sender, e) => {

                Closedialog();

            };
            Button cancel = new Button() { Text = "CANCEL", Left = 150, Width = 70, Top = 120, Height = 30 };
            cancel.Click += (sender, e) => {

                prompt.Close();
                inputBox.Text = "";

            };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(cancel);
            prompt.ShowDialog();
           
        }

        public string Closedialog()
        {
            prompt.Close();
            return inputBox.Text;
        }

    }
}
