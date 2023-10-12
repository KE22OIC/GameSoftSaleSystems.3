using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSoftSaleSystems
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            LabelTitle.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            TextBoxPassword.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxPassword_Click(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text == "Password") TextBoxPassword.Text = "";
        }
    }
}
