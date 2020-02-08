using System.ComponentModel.DataAnnotations;
using Booking.Models;

namespace Booking.Resources
{
    public class SaveSeatResource
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        public int SalonId { get; set; }
        
        [Required]
        public int X { get; set; }
        
        [Required]
        public int Y { get; set; }
    }
}