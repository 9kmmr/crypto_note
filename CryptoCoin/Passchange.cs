using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoCoin
{
    public partial class Passchange : Form
    {
        public Checkenter isenter;
        string hintpath = Path.GetDirectoryName(Application.ExecutablePath) + "/HintData.DAT";
        public Passchange(Checkenter thisenter)
        {
            InitializeComponent();
            isenter = thisenter;
            primarytxt.Text = isenter.primarypass;
            secondarytxt.Text = isenter.secondarypass;
            // get the hint value
            if (File.Exists(hintpath))
            {
                hitntxt.Text = File.ReadAllText(hintpath);
            }else
            {

            }
        }
        // EVENT OPEN THE TEXT FIELD TO EDIT PRIMARY PASS
        private void primarypassbtn_Click(object sender, EventArgs e)
        {
            primarytxt.Enabled = true;
        }
        // EVENT OPEN THE TEXT FIELD TO EDIT SECONDARY PASS
        private void secondarypassbtn_Click(object sender, EventArgs e)
        {
            secondarytxt.Enabled = true;

        }
        // CHANGE LINE
        static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }
        // CLICK THE BACK BUTTON
        private void pwbackbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(primarytxt.Text) || string.IsNullOrWhiteSpace(secondarytxt.Text))
            {
                MessageBox.Show("Password Can not be empty !");
            }
            else
            {
                var result = MessageBox.Show("Do you want to save change ?", "Confirm save",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                if ((result == DialogResult.No))
                {
                    this.Close();
                }
                else
                {
                    Update();
                }
            }
            
        }
        // CHANGE THE PASSWORD
        public void Update()
        {
            
            using (StreamWriter outputFile = new StreamWriter(hintpath,false))
            {
                outputFile.WriteLine(hitntxt.Text);
            }
            using (MD5 md5Hash = MD5.Create())
            {

                string hash1 = GetMd5Hash(md5Hash, primarytxt.Text);
                string hash2 = GetMd5Hash(md5Hash, secondarytxt.Text);
                if (isenter.primarypass != primarytxt.Text)
                {
                    lineChanger(hash1, isenter.path, 1);
                    isenter.primarypass = hash1;
                }
                if (isenter.secondarypass != secondarytxt.Text)
                {
                    lineChanger(hash2, isenter.path, 2);
                    isenter.secondarypass = hash2;
                }

            }
            this.Close();
        }
        // FUNCTION MD5HASH
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
        // EVENT CLICK THE UPDATE PASSWORD
        private void Passchangebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(primarytxt.Text)|| string.IsNullOrWhiteSpace(secondarytxt.Text))
            {
                MessageBox.Show("Password Can not be empty !");
            }
            else
            {
                Update();
            }
        }
        // EVENT OPEN THE TEXT FIELD TO EDIT PRIMARY PASS
        private void primarytxt_Enter(object sender, EventArgs e)
        {
            primarytxt.Text = "";
        }
        // EVENT OPEN THE TEXT FIELD TO EDIT SECONDARY PASS
        private void secondarytxt_Enter(object sender, EventArgs e)
        {
            secondarytxt.Text = "";
        }

        private void hintbtn_Click(object sender, EventArgs e)
        {
            hitntxt.Enabled = true;
        }
    }
}
