using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
           private readonly DataContext _context;


            /// <summary>
            /// Constructor for PostsController
            /// </summary>
            /// <param name="context">Representation of the database "object"</param>
           public PostsController(DataContext context) 
           {
            this._context = context;
           }



            /// <summary>
            /// Method that returns all the Post objects
            /// </summary>
            /// <returns>A list of Posts</returns>
           [HttpGet]
           public async Task<ActionResult<IEnumerable<Post>>> GetPosts()
           {
                return await this._context.Posts.ToListAsync();
           }


            /// <summary>
            /// Method that returns a single Post object by id
            /// </summary>
            /// <param name="id">id of the post being returned</param>
            /// <returns>The post being returned</returns>
           [HttpGet("{id}")]
           public async Task<ActionResult<Post>> GetPost(int id)
           {
                return await this._context.Posts.FindAsync(id);
           }
    }
}