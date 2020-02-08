using System.Collections.Generic;
using System.Threading.Tasks;
using Booking.API.Domain.Services.Communication;
using Booking.Models;
using Booking.Repositories;
using urlshortener.Repositories;

namespace Booking.Services
{
    public class SalonService : ISalonService
    {
        private readonly ISalonRepository _salonRepository;
        private readonly IUnitOfWork _unitOfWork;
        
        public SalonService(ISalonRepository salonRepository, IUnitOfWork unitOfWork)
        {
            _salonRepository = salonRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Salon>> ListAsync()
        {
            return await _salonRepository.ListAsync();
        }

        public async Task<SalonResponse> SaveAsync(Salon salon)
        {
            await _salonRepository.AddAsync(salon);
            await _unitOfWork.CompleteAsync();
            return new SalonResponse(salon);
        }
    }
}