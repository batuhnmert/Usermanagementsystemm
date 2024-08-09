namespace Usermanagementsystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtusername = new Label();
            txtPass = new Label();
            buttonSignin = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            txtRegister = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtusername
            // 
            txtusername.AutoSize = true;
            txtusername.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(76, 17);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(99, 19);
            txtusername.TabIndex = 0;
            txtusername.Text = "Username    :";
            // 
            // txtPass
            // 
            txtPass.AutoSize = true;
            txtPass.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtPass.Location = new Point(76, 46);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(95, 19);
            txtPass.TabIndex = 1;
            txtPass.Text = "Password    :";
            // 
            // buttonSignin
            // 
            buttonSignin.Location = new Point(76, 84);
            buttonSignin.Name = "buttonSignin";
            buttonSignin.Size = new Size(241, 36);
            buttonSignin.TabIndex = 2;
            buttonSignin.Text = "Sign in";
            buttonSignin.UseVisualStyleBackColor = true;
            buttonSignin.Click += buttonSignin_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(172, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(145, 23);
            textBox2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtRegister);
            panel1.Location = new Point(2, 148);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 77);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(228, 26);
            button1.Name = "button1";
            button1.Size = new Size(117, 23);
            button1.TabIndex = 7;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtRegister
            // 
            txtRegister.BackColor = Color.Teal;
            txtRegister.BorderStyle = BorderStyle.None;
            txtRegister.Font = new Font("Poor Richard", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRegister.Location = new Point(13, 26);
            txtRegister.Name = "txtRegister";
            txtRegister.Size = new Size(170, 17);
            txtRegister.TabIndex = 6;
            txtRegister.Text = "Still not registered ? :)";
            txtRegister.TextChanged += textBox3_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(398, 226);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonSignin);
            Controls.Add(txtPass);
            Controls.Add(txtusername);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtusername;
        private Label txtPass;
        private Button buttonSignin;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel1;
        private TextBox txtRegister;
        private Button button1;
    }
}
