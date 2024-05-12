using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBet.DatabaseCommunication
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int Value { get; set; }

        public int OddID { get; set; }
        public int Id { get; set; }

        public Odds? Odds { get; set; }
        public Addict? Addict { get; set; }
    }
}
