using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBet.DatabaseCommunication
{
    
    
        public class Addict
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public int Balance { get; set; }
            public bool Admin { get; set; }

            // Navigation property
            public ICollection<Ticket> Tickets { get; set; }
        }
    
}
