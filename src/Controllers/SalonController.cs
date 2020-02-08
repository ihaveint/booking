using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Booking.Models;
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
        private readonly IMapper _mapper;

        public SalonController(ISalonService salonService, IMapper mapper)
        {
            _salonService = salonService;
            _mapper = mapper;
        }


        [HttpGet]

        public async Task<IEnumerable<SalonResource>> ListAsync()
        {
            var salons = await _salonService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Salon>, IEnumerable < SalonResource >>(salons);

            return resources;
        }

        [HttpPost]
        [ProducesResponseType(typeof(SalonResource), 201)]
        [ProducesResponseType(typeof(ErrorResource), 400)]
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