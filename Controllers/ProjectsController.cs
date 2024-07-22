using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
//Projeto real
namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly FreelanceTotalCostConfig _config;
        public ProjectsController(IOptions<FreelanceTotalCostConfig> options)
        {
            _config = options.Value;
        }


        // api/projects?query=net Core
        [HttpGet]
        public IActionResult Get(string query)
        {
            // Buscar todos ou filtrar
            return Ok();
        }

        // api/projects/3
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Buscar o projeto
            // return NotFound();
            return Ok();
        }

        // POST api/projects
        [HttpPost]
        public IActionResult Post(CreateProjectInputModel model)
        {
            if (model.TotalCost < _config.Minimum || model.TotalCost > _config.Maximum)
            {
                return BadRequest("Numero fora dos limites");
            }
            return CreatedAtAction(nameof(GetById), new { id = 1 }, model);
        }

        // api/projects/2
        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateProjectInputModel model)
        {
            return NoContent();
        }

        // api/project/3
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Buscar, se não existir, retorna NotFound

            // Remover
            return NoContent();
        }

        //PUT api/projects/12345/start
        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        //PUT api/projects/12345/complete
        [HttpPut("{id}/complete")]
        public IActionResult Complete(int id)
        {
            return NoContent();
        }

        // POST api/projects/1234/comments
        [HttpPost("{id}/comments")] 
        public IActionResult PostComment(int id, CreateProjectCommentInputModel model)
        {
            return NoContent();
        }
    }
}
