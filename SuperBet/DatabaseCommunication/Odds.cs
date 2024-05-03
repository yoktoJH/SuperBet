using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBet.DatabaseCommunication
{
    public class Odds
    {
        public int OddID { get; set; }
        public string Category { get; set; }
        public DateTime CloseTime { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Rate { get; set; }
        public bool Winning { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
