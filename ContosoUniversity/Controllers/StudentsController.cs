using System.Threading.Tasks;
using ContosoUniversity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContosoUniversity.Controllers
{
    public class StudentsController : Controller
    {
        private readonly SchoolContext _context;

        public StudentsController(SchoolContext context) {
            _context = context;
        }

        // GET: /<controller>/
        /*public IActionResult Index()
        {
            return View();
        }*/

        public async Task<IActionResult> Index()
        {
            return View(await _context.Students.ToListAsync());
        }
    }
}
