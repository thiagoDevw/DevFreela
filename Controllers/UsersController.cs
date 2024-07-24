using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        // POST api/users
        [HttpPost]
        public IActionResult Post(CreateUserInputModel model)
        {
            return Ok();
        }

        [HttpPost("{id}/skills")]
        public IActionResult PostSkills(UserSkillInputModel model)
        {
            return NoContent();
        }
    }
}
