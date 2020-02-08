using System.Collections.Generic;
using System.Threading.Tasks;
using Booking.Models;
using Microsoft.EntityFrameworkCore;

namespace Booking.Repositories
{
    public class SalonRepository : BaseRepository, ISalonRepository
    {
        public SalonRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Salon>> ListAsync()
        {
            return await _context.salons.ToListAsync();
        }
        
        public async Task AddAsync(Salon salon)
        {
            await _context.salons.AddAsync(salon);
        }
    }
}