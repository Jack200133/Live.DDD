using Live.DDD.API.ApplicationServices;
using Live.DDD.API.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Live.DDD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly LiveServices liveServices;

        public PersonController(LiveServices liveServices)
        {
            this.liveServices = liveServices;
        }
        [HttpPost]

        public async Task<IActionResult> AddPerson(
            CreatePersonCommand createPersonCommand)
        {
            await liveServices.HandleCommand(createPersonCommand);
            return Ok(createPersonCommand);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetPerson(Guid id)
        {
            var response = await liveServices.GetPerson(id);
            return Ok(response);
        }

    }
}
