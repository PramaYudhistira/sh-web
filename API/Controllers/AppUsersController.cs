using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[controller]")] // /api/appusers

    public class AppUsersController : ControllerBase
    {

        private readonly DataContext _context;
        public AppUsersController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            var users = _context.AppUsers.ToList();
            return users;
        }

        /// <summary>
        /// A method that returns a single user
        /// </summary>
        /// <param name="id">The id of the user that is being searched</param>
        /// <returns>The AppUser entity with the id that is being searched</returns>
        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUser(int id)
        {
            var user = _context.AppUsers.Find(id);
            return user;
        }

    }
}