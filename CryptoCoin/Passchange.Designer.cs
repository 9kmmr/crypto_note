namespace CryptoCoin
{
    partial class Passchange
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
            this.pwbackbtn = new System.Windows.Forms.Button();
            this.primarytxt = new System.Windows.Forms.TextBox();
            this.secondarytxt = new System.Windows.Forms.TextBox();
            this.primarypassbtn = new System.Windows.Forms.Button();
            this.secondarypassbtn = new System.Windows.Forms.Button();
            this.Passchangebtn = new System.Windows.Forms.Button();
            this.hitntxt = new System.Windows.Forms.TextBox();
            this.hintbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOCC - Secondary Panel Settings";
            // 
            // pwbackbtn
            // 
            this.pwbackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pwbackbtn.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwbackbtn.Location = new System.Drawing.Point(393, 309);
            this.pwbackbtn.Name = "pwbackbtn";
            this.pwbackbtn.Size = new System.Drawing.Size(75, 47);
            this.pwbackbtn.TabIndex = 1;
            this.pwbackbtn.Text = "<";
            this.pwbackbtn.UseVisualStyleBackColor = true;
            this.pwbackbtn.Click += new System.EventHandler(this.pwbackbtn_Click);
            // 
            // primarytxt
            // 
            this.primarytxt.Enabled = false;
            this.primarytxt.Location = new System.Drawing.Point(221, 90);
            this.primarytxt.Name = "primarytxt";
            this.primarytxt.Size = new System.Drawing.Size(247, 30);
            this.primarytxt.TabIndex = 2;
            this.primarytxt.UseSystemPasswordChar = true;
            this.primarytxt.Enter += new System.EventHandler(this.primarytxt_Enter);
            // 
            // secondarytxt
            // 
            this.secondarytxt.Enabled = false;
            this.secondarytxt.Location = new System.Drawing.Point(221, 146);
            this.secondarytxt.Name = "secondarytxt";
            this.secondarytxt.Size = new System.Drawing.Size(247, 30);
            this.secondarytxt.TabIndex = 2;
            this.secondarytxt.UseSystemPasswordChar = true;
            this.secondarytxt.Enter += new System.EventHandler(this.secondarytxt_Enter);
            // 
            // primarypassbtn
            // 
            this.primarypassbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.primarypassbtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primarypassbtn.Location = new System.Drawing.Point(12, 90);
            this.primarypassbtn.Name = "primarypassbtn";
            this.primarypassbtn.Size = new System.Drawing.Size(203, 30);
            this.primarypassbtn.TabIndex = 3;
            this.primarypassbtn.Text = "Change Primary Pass";
            this.primarypassbtn.UseVisualStyleBackColor = true;
            this.primarypassbtn.Click += new System.EventHandler(this.primarypassbtn_Click);
            // 
            // secondarypassbtn
            // 
            this.secondarypassbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondarypassbtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondarypassbtn.Location = new System.Drawing.Point(12, 146);
            this.secondarypassbtn.Name = "secondarypassbtn";
            this.secondarypassbtn.Size = new System.Drawing.Size(203, 30);
            this.secondarypassbtn.TabIndex = 3;
            this.secondarypassbtn.Text = "Change Secondary Pass";
            this.secondarypassbtn.UseVisualStyleBackColor = true;
            this.secondarypassbtn.Click += new System.EventHandler(this.secondarypassbtn_Click);
            // 
            // Passchangebtn
            // 
            this.Passchangebtn.ForeColor = System.Drawing.Color.Teal;
            this.Passchangebtn.Location = new System.Drawing.Point(126, 257);
            this.Passchangebtn.Name = "Passchangebtn";
            this.Passchangebtn.Size = new System.Drawing.Size(247, 47);
            this.Passchangebtn.TabIndex = 4;
            this.Passchangebtn.Text = "UPDATE";
            this.Passchangebtn.UseVisualStyleBackColor = true;
            this.Passchangebtn.Click += new System.EventHandler(this.Passchangebtn_Click);
            // 
            // hitntxt
            // 
            this.hitntxt.Enabled = false;
            this.hitntxt.Location = new System.Drawing.Point(221, 200);
            this.hitntxt.Name = "hitntxt";
            this.hitntxt.Size = new System.Drawing.Size(247, 30);
            this.hitntxt.TabIndex = 2;
            // 
            // hintbtn
            // 
            this.hintbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hintbtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintbtn.Location = new System.Drawing.Point(12, 200);
            this.hintbtn.Name = "hintbtn";
            this.hintbtn.Size = new System.Drawing.Size(203, 30);
            this.hintbtn.TabIndex = 3;
            this.hintbtn.Text = "Edit Hint";
            this.hintbtn.UseVisualStyleBackColor = true;
            this.hintbtn.Click += new System.EventHandler(this.hintbtn_Click);
            // 
            // Passchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 368);
            this.ControlBox = false;
            this.Controls.Add(this.Passchangebtn);
            this.Controls.Add(this.hintbtn);
            this.Controls.Add(this.secondarypassbtn);
            this.Controls.Add(this.primarypassbtn);
            this.Controls.Add(this.hitntxt);
            this.Controls.Add(this.secondarytxt);
            this.Controls.Add(this.primarytxt);
            this.Controls.Add(this.pwbackbtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Teal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Passchange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOCC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pwbackbtn;
        private System.Windows.Forms.TextBox primarytxt;
        private System.Windows.Forms.TextBox secondarytxt;
        private System.Windows.Forms.Button primarypassbtn;
        private System.Windows.Forms.Button secondarypassbtn;
        private System.Windows.Forms.Button Passchangebtn;
        private System.Windows.Forms.TextBox hitntxt;
        private System.Windows.Forms.Button hintbtn;
    }
}