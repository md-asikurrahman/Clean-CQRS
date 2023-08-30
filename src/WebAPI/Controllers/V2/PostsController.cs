using APIwithCQRS.Dmain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.V2
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class PostsController : Controller
    {
        [HttpGet]
        [Route("{id}")]

        public async Task<IActionResult> GetById(int id)
        {
            var post = new Post { Id = id, Text = "Assalamu-alaikum vai" };
            return Ok(post);
        }

    }
}
