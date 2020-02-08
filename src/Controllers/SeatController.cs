using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Booking.Models;
using booking.Repositories;
using Booking.Resources;
using Booking.Services;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers
{
    [Route("api/v1/salons")]
    [Produces("application/json")]
    [ApiController]
    public class SeatController : Controller
    {
        private readonly  ISeatRepository _seatRepository;
        private readonly ISeatService _seatService;
        private readonly IMapper _mapper;

        public SeatController(ISeatRepository seatRepository, ISeatService seatService, IMapper mapper)
        {
            _seatRepository = seatRepository;
            _seatService = seatService;
            _mapper = mapper;
        }
        
        [HttpGet]
        [Route("{salonId:int}/seats/{seatId:int}")]
        public async Task<IActionResult> Get(int salonId, int seatId)
        {
            var seat = await _seatRepository.FindByIdAsync(seatId);
            if (seat == null)
            {
                return NotFound(new ErrorResource("Seat not found")); 
            } 
            if (seat.SalonId != salonId)
            {
                return BadRequest(new ErrorResource( "this seat doesn't belong to the given salon"));
            }
            return Ok(_mapper.Map<Seat, SeatResource>(seat));
        }
        
        [HttpGet]
        public async Task<IEnumerable<SeatResource>> ListAsync()
        {
            var seats = await _seatService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Seat>, IEnumerable < SeatResource >>(seats);
            
            return resources;
        }

        [HttpPost]
        [Route("{salonId:int}/seats/")]
        [ProducesResponseType(typeof(SalonResource), 201)]
        [ProducesResponseType(typeof(ErrorResource), 400)]
        public async Task<IActionResult> PostAsync([FromBody] SaveSeatResource resource)
        {
            var seat = _mapper.Map<SaveSeatResource, Seat>(resource);
            var result = await _seatService.SaveAsync(seat);
            
            if (!result.Success)
            {
                return BadRequest(new ErrorResource(result.Message));
            }
            
            var seatResource = _mapper.Map<Seat, SeatResource>(result.Resource);
            return Ok(seatResource);
        }
        
        
    }
}