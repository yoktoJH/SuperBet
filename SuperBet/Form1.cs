using SuperBet.DatabaseCommunication;

//await using var db = new SuperBetDb();
namespace SuperBet
{
   
    public partial class Form1 : Form
    {
         

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var db = new SuperBetDb();
            dataGridView1.DataSource = db.Addicts.ToList(); 
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
