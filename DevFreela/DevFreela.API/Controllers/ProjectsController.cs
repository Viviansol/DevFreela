using DevFreela.API.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase



    {
        
        [HttpGet]
        public IActionResult Get(string query)
        {
            return Ok();
        }


        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]

        public IActionResult Post([FromBody] CreateProjectModel createProject )
        {
            if(createProject.Title.Length > 50)
            {
                return BadRequest();
            }
            return CreatedAtAction(nameof(GetById), new { id = createProject.Title }, createProject);
        }

        [HttpPut]

        public IActionResult Put([FromBody] UpdateProjectModel updateProject)
        {
            if (updateProject.Description.Length > 50)
            {
                return BadRequest();
            }
            return NoContent();

        }
        [HttpDelete("{id}")]

        public IActionResult Delete (int id)
        {
            return NoContent();
        }

        //api/projects/1/comments POST

        [HttpPost("{id/comments}")]
        public IActionResult PostComment(int id, [FromBody] CreateCommentsModel createCommentModel)
        {
            return NoContent();
        }

        // api/projects/1/start
        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }
        
        [HttpPut("{id}/finish")]
        public IActionResult Finish (int id)
        {
            return NoContent();    
        }


    }
}
