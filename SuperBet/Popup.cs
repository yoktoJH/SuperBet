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
    public partial class Popup : Form
    {
        private Model _model;
        private int oddID;
        private double _value;
        public Popup(double value, Model model, int oddID)
        {
            InitializeComponent();
            _model = model;
            this.oddID = oddID;
            _value = value;
            label1.Text = "Chceš naozaj vsadiť " + value.ToString()+"€ ?";
            
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            _model.CreateTicket(oddID, _value);
            this.Close();
        }
    }
}
