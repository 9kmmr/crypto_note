namespace CryptoCoin
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.hintbtn = new System.Windows.Forms.Button();
            this.hintval = new System.Windows.Forms.Label();
            this.passchange = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(284, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOCC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(251, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Crypto Coin USB";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(163, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 39);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.UseSystemPasswordChar = true;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // hintbtn
            // 
            this.hintbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hintbtn.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintbtn.Location = new System.Drawing.Point(163, 188);
            this.hintbtn.Name = "hintbtn";
            this.hintbtn.Size = new System.Drawing.Size(53, 22);
            this.hintbtn.TabIndex = 3;
            this.hintbtn.Text = "Hint : ";
            this.hintbtn.UseVisualStyleBackColor = true;
            this.hintbtn.Click += new System.EventHandler(this.hintbtn_Click);
            // 
            // hintval
            // 
            this.hintval.AutoSize = true;
            this.hintval.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintval.Location = new System.Drawing.Point(231, 192);
            this.hintval.Name = "hintval";
            this.hintval.Size = new System.Drawing.Size(37, 15);
            this.hintval.TabIndex = 4;
            this.hintval.Text = "          ";
            // 
            // passchange
            // 
            this.passchange.ForeColor = System.Drawing.Color.Teal;
            this.passchange.Location = new System.Drawing.Point(13, 363);
            this.passchange.Name = "passchange";
            this.passchange.Size = new System.Drawing.Size(75, 50);
            this.passchange.TabIndex = 5;
            this.passchange.Text = "*";
            this.passchange.UseVisualStyleBackColor = true;
            this.passchange.Click += new System.EventHandler(this.passchange_Click);
            // 
            // enter
            // 
            this.enter.ForeColor = System.Drawing.Color.Teal;
            this.enter.Location = new System.Drawing.Point(289, 363);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 50);
            this.enter.TabIndex = 6;
            this.enter.Text = ">";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // exit
            // 
            this.exit.ForeColor = System.Drawing.Color.Teal;
            this.exit.Location = new System.Drawing.Point(570, 363);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 50);
            this.exit.TabIndex = 7;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(285, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 425);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.passchange);
            this.Controls.Add(this.hintval);
            this.Controls.Add(this.hintbtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOCC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button hintbtn;
        private System.Windows.Forms.Label hintval;
        private System.Windows.Forms.Button passchange;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label3;
    }
}

