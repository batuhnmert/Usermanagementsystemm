namespace Usermanagementsystem
{
    partial class Form2
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
            txtname = new Label();
            txtsurname = new Label();
            txtEmail = new Label();
            txtPass = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // txtname
            // 
            txtname.AutoSize = true;
            txtname.Location = new Point(12, 24);
            txtname.Name = "txtname";
            txtname.Size = new Size(48, 15);
            txtname.TabIndex = 0;
            txtname.Text = "Name  :";
            // 
            // txtsurname
            // 
            txtsurname.AutoSize = true;
            txtsurname.Location = new Point(12, 59);
            txtsurname.Name = "txtsurname";
            txtsurname.Size = new Size(63, 15);
            txtsurname.TabIndex = 1;
            txtsurname.Text = "Surname  :";
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Location = new Point(12, 98);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(50, 15);
            txtEmail.TabIndex = 2;
            txtEmail.Text = "E-mail  :";
            // 
            // txtPass
            // 
            txtPass.AutoSize = true;
            txtPass.Location = new Point(12, 136);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(66, 15);
            txtPass.TabIndex = 3;
            txtPass.Text = "Password  :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(105, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(259, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(105, 98);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(259, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(105, 136);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(259, 23);
            textBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(65, 214);
            button1.Name = "button1";
            button1.Size = new Size(247, 56);
            button1.TabIndex = 8;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 179);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(192, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "I have read and accept the rules";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 283);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(txtsurname);
            Controls.Add(txtname);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtname;
        private Label txtsurname;
        private Label txtEmail;
        private Label txtPass;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private CheckBox checkBox1;
    }
}