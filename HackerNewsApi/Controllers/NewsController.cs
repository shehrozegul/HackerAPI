
using HackerNewsApi.Application.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HackerNewsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewsController : Controller
    {
        private readonly IMediator _mediator;

        public NewsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("best")]
        public async Task<IActionResult> GetBestStories([FromQuery] int count)
        {
            var result = await _mediator.Send(new GetBestStoriesCommand(count));

            if (result == null || result.Count == 0)
                return NoContent();

            return Ok(result);
        }
    }
}
