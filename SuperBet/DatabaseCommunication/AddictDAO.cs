using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBet.DatabaseCommunication
{
    public class AddictDAO
    {
        private readonly SuperBetDb _db;

        public AddictDAO(SuperBetDb db)
        {
            _db = db;
        }

        
        public async Task<List<Addict>> GetAllAddictsAsync()
        {
            return await _db.Addicts.ToListAsync();
        }

        
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
    }
}
