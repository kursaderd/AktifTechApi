// Controllers/UsersCoursesController.cs
using Microsoft.AspNetCore.Mvc;
using AktifTechApi.Data;
using AktifTechApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AktifTechApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersCoursesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsersCoursesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<IEnumerable<UsersCourseModel>>> GetUserCourses(int userId)
        {
            return await _context.UsersCourses.Where(uc => uc.UserId == userId).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<UsersCourseModel>> PostUserCourse(UsersCourseModel usersCourseModel)
        {
            _context.UsersCourses.Add(usersCourseModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUserCourses), new { userId = usersCourseModel.UserId }, usersCourseModel);
        }

        private bool UsersCourseModelExists(int id)
        {
            return _context.UsersCourses.Any(e => e.Id == id);
        }
    }
}
