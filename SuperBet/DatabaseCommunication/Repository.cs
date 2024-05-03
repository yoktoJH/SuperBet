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

        // Method to get an addict by id
        public async Task<Addict?> GetAddictByIdAsync(string email)
        {
            return await _db.Addicts.FindAsync(email);
        }

        // Method to add a new addict
        public async Task AddAddictAsync(Addict addict)
        {
            _db.Add(addict);
            await _db.SaveChangesAsync();
        }

        // Method to update an existing addict
        public async Task UpdateAddictAsync(Addict addict)
        {
            _db.Update(addict);
            await _db.SaveChangesAsync();
        }

        // Method to delete an addict
        public async Task DeleteAddictAsync(Addict addict)
        {
            _db.Remove(addict);
            await _db.SaveChangesAsync();
        }
    }

}
