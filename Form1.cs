using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_Send_Simulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;

            string email = textBox2.Text;

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                if (addr.Address == email)
                {
                    flag = true;
                    MessageBox.Show("Incorrect E-email!");
                }
                   

            }
            catch (Exception)
            {
                flag = false;
            }

            if (flag)
            {
                Mail_Sender.Send_Mail("piotr.murdzia.csharp.testy@gmail.com", email, richTextBox1.Text, "C# Mailer, Piotr Murdzia");
                MessageBox.Show("Message send!");
            }
            else
            {
                MessageBox.Show("!!!ERROR!!!");
            }
                
        }
    }
}
