using AutoMapper;
using Booking.Models;
using Booking.Resources;

namespace Booking.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Salon, SalonResource>();
        }
    }
}