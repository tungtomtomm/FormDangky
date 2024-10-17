namespace FormDangnhap
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textMatkhau = new System.Windows.Forms.TextBox();
            this.textMatkhau2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dang ky";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonHuy
            // 
            this.buttonHuy.Location = new System.Drawing.Point(165, 176);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(75, 23);
            this.buttonHuy.TabIndex = 1;
            this.buttonHuy.Text = "Huy";
            this.buttonHuy.UseVisualStyleBackColor = true;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mat khau";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nhap lai mat khau";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Dang ky";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(114, 56);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(126, 20);
            this.textEmail.TabIndex = 6;
            // 
            // textMatkhau
            // 
            this.textMatkhau.Location = new System.Drawing.Point(114, 82);
            this.textMatkhau.Name = "textMatkhau";
            this.textMatkhau.Size = new System.Drawing.Size(126, 20);
            this.textMatkhau.TabIndex = 7;
            this.textMatkhau.TextChanged += new System.EventHandler(this.textMatkhau_TextChanged);
            // 
            // textMatkhau2
            // 
            this.textMatkhau2.Location = new System.Drawing.Point(114, 108);
            this.textMatkhau2.Name = "textMatkhau2";
            this.textMatkhau2.Size = new System.Drawing.Size(126, 20);
            this.textMatkhau2.TabIndex = 8;
            this.textMatkhau2.TextChanged += new System.EventHandler(this.textMatkhau2_TextChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textMatkhau2);
            this.Controls.Add(this.textMatkhau);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button_Dangky;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textMatkhau;
        private System.Windows.Forms.TextBox textMatkhau2;
    }
}

