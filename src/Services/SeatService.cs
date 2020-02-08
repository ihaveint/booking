using System.Collections.Generic;
using System.Threading.Tasks;
using Booking.API.Domain.Services.Communication;
using Booking.Models;
using booking.Repositories;
using urlshortener.Repositories;

namespace Booking.Services
{
    public class SeatService : ISeatService
    {
        private readonly ISeatRepository _seatRepository;
        private readonly IUnitOfWork _unitOfWork;
        
        public SeatService(ISeatRepository seatRepository, IUnitOfWork unitOfWork)
        {
            _seatRepository = seatRepository;
            _unitOfWork = unitOfWork;
        }
        
        public async Task<IEnumerable<Seat>> ListAsync()
        {
            return await _seatRepository.ListAsync();
        }

        public async Task<SeatResponse> SaveAsync(Seat seat)
        {
            await _seatRepository.AddAsync(seat);
            await _unitOfWork.CompleteAsync();
            return new SeatResponse(seat);
        }
    }
}