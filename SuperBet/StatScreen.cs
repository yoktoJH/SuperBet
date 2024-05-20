using ScottPlot;
using SuperBet.DatabaseCommunication;
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
    public partial class StatScreen : Form
    {
        private ScreenStorage _screens;
        private Model _model;
        private Addict? _user = null;
        private List<Ticket> tickets = new List<Ticket>();
        public StatScreen(ScreenStorage screens, Model model)
        {
            InitializeComponent();
            _screens = screens;
            _model = model;
        }

        public void UpdateVisuals()
        {
            tickets = _model.GetTickets();


            List<PieSlice> pieSlices = new()
            {
                new PieSlice(){Value = tickets.Where(t =>t.Odds.CloseTime < DateTime.Today && !t.Odds.Winning).Count() ,FillColor = Colors.Red , Label = "Prehry"},
                new PieSlice(){Value = tickets.Where(t =>t.Odds.CloseTime < DateTime.Today && t.Odds.Winning).Count() ,FillColor = Colors.Green , Label = "Výhry"},
                new PieSlice(){Value = tickets.Where(t =>t.Odds.CloseTime  >=DateTime.Today).Count() ,FillColor = Colors.Grey , Label = "Nerozhodnuté"},
            };
            formsPlot1.Plot.Clear();
            var pie = formsPlot1.Plot.Add.Pie(pieSlices);
            formsPlot1.Plot.ShowLegend();

            var sum = tickets.Where(t => t.Odds.CloseTime < DateTime.Today).Select(t => t.Odds.Winning ? t.Value * t.Odds.Rate : -t.Value).Sum();
            label3.Text = sum.ToString();

            listBox1.Items.Clear();
            foreach (var item in tickets)
            {
                if (item == null)
                {
                    continue;
                }
                string status = "nerozhodnuté";
                if (item.Odds.CloseTime < DateTime.Today)
                {
                    if (item.Odds.Winning)
                    {
                        status = "výhra";
                    }
                    else
                    {
                        status = "prehra";
                    }
                }

                var row = string.Format("{0,-20}{1,-20}{2,-20}{3}", item.Odds.Name, item.Value, item.Odds.Rate.ToString() + "x", status);

                listBox1.Items.Add(row);
            }


        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _model.LogoutUser();
            this.Hide();
            _screens.login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            _screens.admin.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = tickets[listBox1.SelectedIndex].Odds.Name;
            label4.Text = tickets[listBox1.SelectedIndex].Odds.Description;
        }


    }
}
