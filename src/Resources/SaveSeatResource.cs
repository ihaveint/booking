using System.ComponentModel.DataAnnotations;

namespace Booking.Resources
{
    public class SaveSeatResource
    {
        [Required]
        public int Id { get; set; }
        
        public int SalonId { get; set; }
        
        [Required]
        public int X { get; set; }
        
        [Required]
        public int Y { get; set; }
    }
}