using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;
using System;


namespace Usermanagementsystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromFile("serviceAccountKey.json")
                
            });

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text.Trim();
                string surname = textBox2.Text.Trim();
                string email = textBox3.Text.Trim();
                string password = textBox4.Text.Trim();

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Email and password fields cannot be left blank.");
                    return;
                }

                var user = await FirebaseAuth.DefaultInstance.CreateUserAsync( new UserRecordArgs() 
                {
                    Email = email,
                    Password = password,

                });

                MessageBox.Show("Registration successful! Please login.");
            }
            catch (Exception ex) {
                MessageBox.Show($"An error occurred during registration: {ex.Message}");
            }
        }
    }
}
