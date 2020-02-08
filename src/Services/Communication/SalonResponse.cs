using Booking.Models;

namespace Booking.API.Domain.Services.Communication
{
    public class SalonResponse : BaseResponse<Salon>
    {

        public SalonResponse(Salon salon) : base(salon)
        {
        }

        public SalonResponse(string message) : base(message)
        {
        }
    }
}