using Booking.Models;

namespace Booking.API.Domain.Services.Communication
{
    public class SeatResponse : BaseResponse<Seat>
    {
        
        public SeatResponse(Seat resource) : base(resource)
        {
        }

        public SeatResponse(string message) : base(message)
        {
        }
    }
}