using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usermanagementsystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += $"\n{textBox2.Text}";
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form1 = new Form1();
            form1.Show();
        }
    }
}
