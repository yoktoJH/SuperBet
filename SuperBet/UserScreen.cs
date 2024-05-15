using Microsoft.VisualBasic;
using SuperBet.DatabaseCommunication;
using SuperBet.UiElements;
using System.Data;

namespace SuperBet
{
    public partial class UserScreen : Form
    {
        private ScreenStorage _screens;
        private Model _model;
        private Addict? _user = null;
        public UserScreen(ScreenStorage screens, Model model)
        {
            InitializeComponent();
            _screens = screens;
            _model = model;

        }

        public void SetUser(Addict user)
        {
            _user = user;
        }

        private void betAmount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(betAmount.Text) && !betAmount.Text.EndsWith("€"))
            {
                betAmount.Text += "€";
                betAmount.SelectionStart = betAmount.Text.Length - 1; // to keep the cursor before the '$'
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //_model.onetimeinsertdata();
            if (Double.TryParse(betAmount.Text.Substring(0,betAmount.Text.Length-1),out double value))
            {
                Popup popup = new Popup(value, _model,listBox1.SelectedIndex);
                popup.ShowDialog();

            }
            
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            var x = _model.OddsCategories();
            checkedListBox1.Items.AddRange(x);
            //checkedListBox1.SelectedItems
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _model.LogoutUser();
            this.Hide();
            _screens.login.Show();

        }

        private void UpdateListView(string category)
        {

            _model.ShowOddsInCategories(category);

        }


        



        private void betAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
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
                var row = string.Format("{0}{1}{2}x", item.Name.PadRight(50), item.CloseTime.ToShortDateString().PadRight(50), item.Rate.ToString());

                listBox1.Items.Add(row);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0 || listBox1.SelectedIndex >= _model.OddsToShow.Count)
            {
                return;
            }
            var odd = _model.OddsToShow[listBox1.SelectedIndex];
            betName.Text = odd.Name;
            label1.Text = odd.Description;
            label3.Text = odd.Rate.ToString();
        
        }
    }
}
