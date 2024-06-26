﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Streaming.Adaptive;

namespace SuperBet.DatabaseCommunication
{
    public class OddsDAO
    {
        private readonly SuperBetDb _db;

        public OddsDAO(SuperBetDb db)
        {
            _db = db;
        }
        
        public async Task<List<Odds>> GetAllAsync()
        {
            return await _db.Odds.ToListAsync();
        }


        public async Task<Odds?> GetByIdAsync(int id)
        {
            return await _db.Odds.FindAsync(id);
        }

        public async Task<List<Odds>> GetByCategory(string category,bool active)
        {
            return await _db.Odds.Where(a => a.Category == category && (!active || a.CloseTime > DateTime.Today)).ToListAsync();
        }

        public async Task AddAsync(Odds odds)
        {
            _db.Add(odds);
            await _db.SaveChangesAsync();
        }


        public async Task UpdateAsync(Odds odds)
        {
            _db.Update(odds);
            await _db.SaveChangesAsync();
        }


        public async Task DeleteAsync(Odds odds)
        {
            _db.Remove(odds);
            await _db.SaveChangesAsync();
        }
    }
}
