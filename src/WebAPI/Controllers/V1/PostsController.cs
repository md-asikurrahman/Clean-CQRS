using APIwithCQRS.Dmain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class PostsController : Controller
    {
        [HttpGet]
        [Route("{id}")]

        public async Task<IActionResult> GetById(int id)
        {
            var post = new Post { Id = id, Text = "Assalamu-alaikum" };
            return Ok(post);
        }

    }
}
