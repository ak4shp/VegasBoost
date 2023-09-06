using Microsoft.AspNetCore.Mvc;
using VegasBoost.Contracts.Vegas;

namespace VegasBoost.Controllers
{
    [ApiController]
    public class BreakfastController : ControllerBase
    {
        [HttpPost("/breakfast")]
        public IActionResult CreateBreakfast(CreateBreakfastRequest request)
        {
            return Ok(request);
        }


        [HttpGet("/breakfast/{id:guid}")]
        public IActionResult GetBreakfast(Guid id)
        {
            return Ok(id);
        }


        [HttpPut("/breakfast{id:Guid}")]
        public IActionResult UpsertBreakfast(Guid id, UpsertBreakfastRequest request)
        {
            return Ok(request);
        }


        [HttpDelete("/breakfast/{id:guid}")]
        public IActionResult DeleteBreakfast(Guid id)
        {
            return Ok(id);
        }

    }
}