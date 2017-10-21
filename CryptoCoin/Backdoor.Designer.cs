namespace CryptoCoin
{
    partial class Backdoor
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
            this.label3 = new System.Windows.Forms.Label();
            this.backdoorenter = new System.Windows.Forms.Button();
            this.backpass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(180, 9);
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
            this.label2.Location = new System.Drawing.Point(114, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Secondary Panel Settings";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(101, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 36);
            this.textBox1.TabIndex = 2;
            this.textBox1.UseSystemPasswordChar = true;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(145, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Secondary Password";
            // 
            // backdoorenter
            // 
            this.backdoorenter.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backdoorenter.ForeColor = System.Drawing.Color.Teal;
            this.backdoorenter.Location = new System.Drawing.Point(186, 203);
            this.backdoorenter.Name = "backdoorenter";
            this.backdoorenter.Size = new System.Drawing.Size(75, 38);
            this.backdoorenter.TabIndex = 4;
            this.backdoorenter.Text = ">";
            this.backdoorenter.UseVisualStyleBackColor = true;
            this.backdoorenter.Click += new System.EventHandler(this.backdoorenter_Click);
            // 
            // backpass
            // 
            this.backpass.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backpass.ForeColor = System.Drawing.Color.Teal;
            this.backpass.Location = new System.Drawing.Point(309, 203);
            this.backpass.Name = "backpass";
            this.backpass.Size = new System.Drawing.Size(75, 38);
            this.backpass.TabIndex = 5;
            this.backpass.Text = "<";
            this.backpass.UseVisualStyleBackColor = true;
            this.backpass.Click += new System.EventHandler(this.backpass_Click);
            // 
            // Backdoor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 253);
            this.ControlBox = false;
            this.Controls.Add(this.backpass);
            this.Controls.Add(this.backdoorenter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Backdoor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOCC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backdoorenter;
        private System.Windows.Forms.Button backpass;
    }
}