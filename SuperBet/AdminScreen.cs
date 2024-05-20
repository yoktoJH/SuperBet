using SuperBet.DatabaseCommunication;
using SuperBet.UiElements;

namespace SuperBet
{
    public partial class AdminScreen : Form
    {
        private ScreenStorage _screens;
        private Model _model;
        public AdminScreen(ScreenStorage screens, Model model)
        {
            InitializeComponent();
            _screens = screens;
            _model = model;
        }

        private void UpdateListBox()
        {

        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            var x = _model.OddsCategories();
            comboBox1.Items.AddRange(x);
            checkedListBox1.Items.AddRange(x);
            //checkedListBox1.SelectedItems
        }

        private void UpdateListView(string category)
        {

            _model.ShowOddsInCategoriesAdmin(category);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //_model.onetimeinsertdata();

            if (Double.TryParse(oddRateTB.Text, out double value))
            {
                var newOdd = new Odds { OddID = 0, Category = comboBox1.SelectedItem as string, CloseTime = dateTimePicker1.Value, Name = textBox2.Text, Description = textBox3.Text, Rate = value };
                _model.AddOdds(newOdd);
            }

        }

        private async void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (e.NewValue == CheckState.Checked)
            {
                await Task.Run(() => UpdateListView(checkedListBox1.Items[e.Index] as string));
            }
            else
            {
                _model.OddsToShow.RemoveAll(a => a.Category == checkedListBox1.Items[e.Index] as string);
            }


            listBox1.Items.Clear();
            foreach (var item in _model.OddsToShow)
            {
                if (item == null)
                {
                    continue;
                }
                var row = string.Format("{0}{1}{2}{3}", item.Name.PadRight(30), item.CloseTime.ToShortDateString().PadRight(10), (item.Rate.ToString() + "x").PadRight(20), item.Winning);

                listBox1.Items.Add(row);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _model.LogoutUser();
            this.Hide();
            _screens.login.Show();

        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var odd = _model.OddsToShow[listBox1.SelectedIndex];
            if (odd.CloseTime >= DateTime.Today)
            {
                return;
            }
            odd.Winning = true;
            _model.UpdateOdds(odd);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var odd = _model.OddsToShow[listBox1.SelectedIndex];
            if (odd.CloseTime >= DateTime.Today)
            {
                return;
            }
            odd.Winning = false;
            _model.UpdateOdds(odd);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            _screens.stat.UpdateVisuals();
            _screens.stat.Show();
        }
    }
}
