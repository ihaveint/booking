using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Booking.Models;
using Booking.Repositories;
using Booking.Resources;
using Booking.Services;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers
{
    [Route("api/v1/salons/")]
    [Produces("application/json")]
    [ApiController]
    public class SalonController : Controller
    {
        private readonly  ISalonService _salonService;
        private readonly ISalonRepository _salonRepository;
        private readonly IMapper _mapper;

        public SalonController(ISalonService salonService, ISalonRepository salonRepository, IMapper mapper)
        {
            _salonService = salonService;
            _salonRepository = salonRepository;
            _mapper = mapper;
        }
        
        [HttpGet]
        public async Task<IEnumerable<SalonResource>> ListAsync()
        {
            var salons = await _salonService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Salon>, IEnumerable < SalonResource >>(salons);

            return resources;
        }

        [HttpGet("{salonId:int}")]
        public async Task<IActionResult> Get(int salonId)
        {
            var salon = await _salonRepository.FindByIdAsync(salonId);
            if (salon == null)
            {
                return NotFound(new ErrorResource("Salon not found")); 
            }
            return Ok(_mapper.Map<Salon, SalonResource>(salon));
        }
        
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveSalonResource resource)
        {
            var salon = _mapper.Map<SaveSalonResource, Salon>(resource);
            var result = await _salonService.SaveAsync(salon);

            if (!result.Success)
            {
                return BadRequest(new ErrorResource(result.Message));
            }

            var salonResource = _mapper.Map<Salon, SalonResource>(result.Resource);
            return Ok(salonResource);
        }
    }
}