using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBet.DatabaseCommunication
{
    public class TicketDAO
    {
        private readonly SuperBetDb _db;

        public TicketDAO(SuperBetDb db)
        {
            _db = db;
        }


        public async Task<List<Ticket>> GetAllAsync()
        {
            return await _db.Ticket.ToListAsync();
        }


        public async Task<List<Ticket>> GetByAllAddictAsync(int id)
        {
            return await _db.Ticket.Where(a => a.Id == id).ToListAsync();
        }

        public async Task<Ticket?> GetByIdAsync(int id)
        {
            return await _db.Ticket.FindAsync(id);
        }


        public async Task AddAsync(Ticket ticket)
        {
            _db.Add(ticket);
            await _db.SaveChangesAsync();
        }


        public async Task UpdateAsync(Ticket ticket)
        {
            _db.Update(ticket);
            await _db.SaveChangesAsync();
        }


        public async Task DeleteAsync(Ticket ticket)
        {
            _db.Remove(ticket);
            await _db.SaveChangesAsync();
        }


    }
}
