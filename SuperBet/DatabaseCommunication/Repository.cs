using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBet.DatabaseCommunication
{
    public class Repository
    {
        private readonly SuperBetDb _db;

        public Repository(SuperBetDb database)
        {
            _db = database;
        }

        // Method to get all addicts
        public async Task<List<Addict>> GetAllAddictsAsync()
        {
            return await _db.Addicts.ToListAsync();
        }

        // addict funcitons
        public async Task<Addict?> GetAddictByIdAsync(int id)
        {
            return await _db.Addicts.FindAsync(id);
        }

        public async Task<Addict?> GetAddictByEmailAsync(string email)
        {
            return await _db.Addicts.FirstOrDefaultAsync(a => a.Email == email);
        }
        
        
        public async Task AddAddictAsync(Addict addict)
        {
            _db.Add(addict);
            await _db.SaveChangesAsync();
        }

        
        public async Task UpdateAddictAsync(Addict addict)
        {
            _db.Update(addict);
            await _db.SaveChangesAsync();
        }

        
        public async Task DeleteAddictAsync(Addict addict)
        {
            _db.Remove(addict);
            await _db.SaveChangesAsync();
        }

        // odds fuctions
        public async Task<List<Odds>> GetAllOddsAsync()
        {
            return await _db.Odds.ToListAsync();
        }

     
        public async Task<Odds?> GetOddsByIdAsync(int id)
        {
            return await _db.Odds.FindAsync(id);
        }

        public async Task AddOddsAsync(Odds odds)
        {
            _db.Add(odds);
            await _db.SaveChangesAsync();
        }

  
        public async Task UpdateOddsAsync(Odds odds)
        {
            _db.Update(odds);
            await _db.SaveChangesAsync();
        }

        
        public async Task DeleteOddsAsync(Odds odds)
        {
            _db.Remove(odds);
            await _db.SaveChangesAsync();
        }

        // addict funcitons
        public async Task<Ticket?> GetTicketByIdAsync(int id)
        {
            return await _db.Ticket.FindAsync(id);
        }


        public async Task AddTicketAsync(Ticket ticket)
        {
            _db.Add(ticket);
            await _db.SaveChangesAsync();
        }


        public async Task UpdateTicketAsync(Ticket ticket)
        {
            _db.Update(ticket);
            await _db.SaveChangesAsync();
        }


        public async Task DeleteTicketAsync(Ticket ticket)
        {
            _db.Remove(ticket);
            await _db.SaveChangesAsync();
        }
    }

}
