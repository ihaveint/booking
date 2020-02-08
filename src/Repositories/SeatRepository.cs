using System.Collections.Generic;
using System.Threading.Tasks;
using Booking;
using Booking.Models;
using Booking.Repositories;
using Microsoft.EntityFrameworkCore;

namespace booking.Repositories
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