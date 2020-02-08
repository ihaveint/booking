using System.Threading.Tasks;
using Booking;

namespace urlshortener.Repositories
{
    /*
        we use this class for transaction
     */
    public class UnitOfWork : IUnitOfWork
    {
        
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        // call this function for saving the changes to database
        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}