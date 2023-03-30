using BasicSecuryASP.Models;
using BasicSecuryASP.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicSecuryASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BeerController : ControllerBase
    {
        private readonly IBeerService _beerService;
        public BeerController(IBeerService beerServive)
        {
                _beerService = beerServive;
        }

        [HttpGet]
        public async Task<IEnumerable<Beer>> Get() => await _beerService.Get();
    }
}
