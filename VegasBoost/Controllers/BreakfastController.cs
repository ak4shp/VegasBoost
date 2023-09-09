using Microsoft.AspNetCore.Mvc;
using VegasBoost.Contracts.Vegas;
using VegasBoost.Models;
using VegasBoost.Services.Breakfasts;

namespace VegasBoost.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BreakfastController : ControllerBase
    {
        private readonly IBreakfastService _breakfastService;

        public BreakfastController(IBreakfastService breakfastService)
        {
            _breakfastService = breakfastService;
        }


        [HttpPost("")]
        public IActionResult CreateBreakfast(CreateBreakfastRequest request)
        {
            var breakfast = new Breakfast(
                Guid.NewGuid(),
                request.Name,
                request.Description,
                request.StartDateTime,
                request.EndDateTime,
                DateTime.UtcNow,
                request.Savory,
                request.Sweet);
            //ToDO: Save nreakfast to database
            _breakfastService.CreateBreakfast(breakfast);


            var response = new BreakfastResponse(
                breakfast.Id,
                breakfast.Name,
                breakfast.Description,
                breakfast.EndDateTime,
                breakfast.StartDateTime,
                breakfast.LastModifiedDateTime,
                breakfast.Savory,
                breakfast.Sweet);
                
            return CreatedAtAction(
                actionName: nameof(GetBreakfast),
                routeValues: new {id = breakfast.Id},
                value: response);
        }


        [HttpGet("{id:guid}")]
        public IActionResult GetBreakfast(Guid id)
        {
            Breakfast breakfast = _breakfastService.GetBreakfast(id);
            return Ok(id);
        }


        [HttpPut("{id:guid}")]
        public IActionResult UpsertBreakfast(Guid id, UpsertBreakfastRequest request)
        {
            return Ok(request);
        }


        [HttpDelete("{id:guid}")]
        public IActionResult DeleteBreakfast(Guid id)
        {
            return Ok(id);
        }

    }
}