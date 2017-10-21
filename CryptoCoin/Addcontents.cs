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

namespace CryptoCoin
{
    public partial class Addcontents : Form
    {
        public Checkenter isenter;
        public Addcontents( Checkenter thisenter)
        {
            InitializeComponent();
            isenter = thisenter;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Boolean checkempty = true;
            if (string.IsNullOrWhiteSpace(nametxt.Text))
            {
                errorProvider1.SetError(nametxt, "Name cant be empty!");
                nametxt.Focus();
                checkempty = false;
            }
            else errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(curtxt.Text))
            {
                errorProvider1.SetError(curtxt, "Currency cant be empty!");
                curtxt.Focus();
                checkempty = false;
            }
            else errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(publictxt.Text))
            {
                errorProvider1.SetError(publictxt, "Public Address cant be empty");
                publictxt.Focus();
                checkempty = false;
            }
            else errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(privatetxt.Text))
            {
                errorProvider1.SetError(privatetxt, "Private Address cant be empty");
                checkempty = false;
                privatetxt.Focus();
            }
            else errorProvider1.Clear();
            if (checkempty)
            {
                 errorProvider1.Clear();
                 contents newcontent = new contents();
                newcontent.name = nametxt.Text;
                newcontent.currency = curtxt.Text;
                newcontent.publicaddress = publictxt.Text;
                newcontent.privateaddress = privatetxt.Text;
                newcontent.notes = notesrb.Text;
                string json = JsonConvert.SerializeObject(newcontent);
                isenter.savetofile(json);
                MessageBox.Show("data added successfully");
            }
            
        }
    }
}
