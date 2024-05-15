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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
