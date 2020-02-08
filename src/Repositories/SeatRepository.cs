using System.Collections.Generic;
using System.Threading.Tasks;
using Booking.Models;
using Microsoft.EntityFrameworkCore;

namespace Booking.Repositories
{
    public class SeatRepository : BaseRepository,  ISeatRepository
    {
        public SeatRepository(AppDbContext context) : base(context) { }
        
        public async Task<IEnumerable<Seat>> ListAsync()
        {
            return await _context.seats.ToListAsync();
        }

        public async Task AddAsync(Seat seat)
        {
            await _context.seats.AddAsync(seat);
        }

        public async Task<Seat> FindByIdAsync(int id)
        {
            return await _context.seats.FindAsync(id);
        }
    }
}