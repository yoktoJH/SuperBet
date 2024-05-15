using SuperBet.UiElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperBet
{
    public partial class LoginScreen : Form

    {
        private ScreenStorage _screens;
        private Model _model;
        public LoginScreen(ScreenStorage screens, Model model)
        {
            InitializeComponent();
            _screens = screens;
            _model = model;
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            _screens.register.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_model.LoginUser(textBox2.Text, textBox1.Text))
            {
                label4.Visible = false;
                //label4.Text = "PRIhásenie succcccc esfullll";
                this.Hide();
                textBox1.Clear();
                textBox2.Clear();
                _screens.user.Show();
            }
            label4.Visible = true;
        }

        private void LoginScreen_Shown(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
