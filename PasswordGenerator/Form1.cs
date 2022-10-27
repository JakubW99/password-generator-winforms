using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        int currentPasswordLength = 0;
        Random character = new Random();
        private void passwordGenerator(int PasswordLength)
        {
            String allCharacters = "ABCDEFGHIJKLMOPRSTUWXYZ0123456789abcdefghijklmnopqrstuvwxyz?!.@#$%^&*()-+_=/{}[]";
            string RandomPassword = "";
            for (int i = 0; i < PasswordLength; i++)
            {
                int randomNUM = character.Next(0,allCharacters.Length);
                RandomPassword += allCharacters[randomNUM];
            }
            label1.Text = RandomPassword;
        }
        public Form1()
        {
           
            InitializeComponent();
            trackBar1.Minimum = 5;
            trackBar1.Maximum = 20;
            passwordGenerator(5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label1.Text);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = "Password Length:" + trackBar1.Value.ToString();
            currentPasswordLength = trackBar1.Value;
            passwordGenerator(currentPasswordLength);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Password Length:" + trackBar1.Value.ToString();
            currentPasswordLength = trackBar1.Value;
            passwordGenerator(currentPasswordLength);
        }
    }
}
