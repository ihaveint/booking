using System.ComponentModel.DataAnnotations;

namespace Booking.Resources
{
    public class SaveSalonResource
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        
        [Required]
        public int SeatWidth { get; set; }
        
        [Required]
        public int SeatHeight { get; set; }
    }
}