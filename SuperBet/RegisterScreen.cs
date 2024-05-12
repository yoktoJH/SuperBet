using SuperBet.UiElements;

namespace SuperBet
{
    public partial class RegisterScreen : Form
    {
        private ScreenStorage _screens;
        private Model _model;
        private readonly object dummy = new object();
        public RegisterScreen(ScreenStorage screens, Model model)
        {
            InitializeComponent();
            _screens = screens;
            progressBar1.Visible = false;
            progressBar1.Minimum = 1;
            progressBar1.Maximum = 10;
            progressBar1.Value = 1;
            progressBar1.Step = 1;
            _model = model;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void RegisterScreen_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private bool ValidInput()
        {
            return nameBox.Tag != null && surnameBox.Tag != null && dateTimePicker1.Tag != null
                    && passwordBox.Tag != null && controlBox != null && checkBox1.Checked;
        }

        private async Task Register()
        {
            var res = _model.RegisterAddict(nameBox.Text + " " + surnameBox.Text, emailBox.Text, passwordBox.Text);
            while (!res.IsCompleted && progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
                await Task.Delay(100);
            }
            await res;
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            if (!ValidInput())
            {
                return;
            }
            label14.Visible = true;
            progressBar1.Visible = true;
            //progressBar1.Refresh();
            var res = Register();
            progressBar1.PerformStep();
            //label11.Text = "hehhe";
            await res;
            button3_Click(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            _screens.login.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            if (_model.IsValidName(nameBox.Text))
            {
                label11.Text = "";
                nameBox.Tag = dummy;
            }
            else
            {
                label11.Text = "Nesprávny fromát mena";
                nameBox.Tag = null;
            }
        }

        private void surnameBox_TextChanged(object sender, EventArgs e)
        {
            if (_model.IsValidName(surnameBox.Text))
            {
                label10.Text = "";
                surnameBox.Tag = dummy;
            }
            else
            {
                label10.Text = "Nesprávny fromát priezviska";
                surnameBox.Tag = null;
            }
        }
        private void emailBox_TextChanged(object sender, EventArgs e)
        {
            if (_model.IsValidEmail(emailBox.Text))
            {
                label9.Text = "";
                emailBox.Tag = dummy;
            }
            else
            {
                label9.Text = "Nevalídny email";
                emailBox.Tag = null;
            }
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordBox.Text.Length >= 8)
            {
                label12.Text = "";
                passwordBox.Tag = dummy;
            }
            else
            {
                label12.Text = "Heslo by malo mať aspoň 8 znakov";
                passwordBox.Tag = null;
            }
            controlBox_TextChanged(sender, e);
        }

        private void controlBox_TextChanged(object sender, EventArgs e)
        {
            if (controlBox.Text == passwordBox.Text)
            {
                label13.Text = "";
                controlBox.Tag = dummy;
            }
            else
            {
                label13.Text ="Heslo sa nezhoduje";
                controlBox.Tag = null;
            }
        }
        private void dateTimePicker1_ValueChanged(Object sender, EventArgs e)
        {
            var age = DateTime.Today.Year - dateTimePicker1.Value.Year ;
            if (dateTimePicker1.Value > DateTime.Today)
            {
                label8.Text = "Cestovanie v čase je zásadne proti pravidlám";
                dateTimePicker1.Tag = null;
            }
            else if (age < 18 )
            {
                label8.Text = "Žiadne deti! Ihneď to vypni!";
                dateTimePicker1.Tag = null;
            }
            else if(age > 100)
            {
                label8.Text = "V tomto veku to už aj stávkovým\n kanceláriám príde nemorálne";
                dateTimePicker1.Tag = null;

            }
            else
            {
                label8.Text = "";
                dateTimePicker1.Tag = dummy;

            }
        }
    }
}
