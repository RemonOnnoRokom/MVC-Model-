using Learn.AspNetCore.Basic.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Learn.AspNetCore.Basic.Controllers
{
    public class MovieController : Controller
    {
        public readonly BasicDbContext _obj;
        public MovieController(BasicDbContext obj)
        {
            _obj = obj;
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var movie = await _obj.Movies.FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: Movie List
        public async Task<IActionResult> Index()
        {
            return View(await _obj.Movies.ToListAsync());
        }

    }
}
