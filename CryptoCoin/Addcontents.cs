using System;
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
        public Boolean checkemptyfield(TextBox textbox)
        {
            if (string.IsNullOrWhiteSpace(textbox.Text))
            {
                errorProvider1.SetError(textbox, "This field cant be empty!");
                textbox.Focus();
                return false;
            }
            else { errorProvider1.Clear(); return true; }

        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            Boolean checkempty = true;
            if (!(checkemptyfield(nametxt)&& checkemptyfield(nametxt)&& checkemptyfield(curtxt) &&checkemptyfield(publictxt) && checkemptyfield(privatetxt)))
            {
                checkempty = false;
            }
           
            
            if (checkempty)
            {
                 errorProvider1.Clear();
                 contents newcontent = new contents();
                cryptdata cryptdata = new cryptdata();
                newcontent.name ="";
                newcontent.currency = "";
                newcontent.publicaddress ="";
                newcontent.privateaddress = "";
                newcontent.notes = "";
                try
                {
                    newcontent.name = cryptdata.EncryptStringAES(nametxt.Text, "lamvu");
                    newcontent.currency = cryptdata.EncryptStringAES(curtxt.Text, "lamvu");
                    newcontent.publicaddress = cryptdata.EncryptStringAES(publictxt.Text, "lamvu");
                    newcontent.privateaddress = cryptdata.EncryptStringAES(privatetxt.Text, "lamvu");
                    newcontent.notes = cryptdata.EncryptStringAES(notesrb.Text, "lamvu");
                    
                }
                catch (Exception)
                {

                }
                string json = JsonConvert.SerializeObject(newcontent);
                isenter.savetofile(json);
                MessageBox.Show("data added successfully");

            }
            else
            {
                MessageBox.Show("Add data failed . \n Please check again.");
            }
            
        }
    }
}
