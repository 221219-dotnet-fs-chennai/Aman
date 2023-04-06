using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private readonly PracticeDBContext _practiceDBContext;
        public HomeController(PracticeDBContext practiceDBContext)
        {
            _practiceDBContext= practiceDBContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployee()
        {
            var employee = await _practiceDBContext.practices.ToListAsync();
            return Ok(employee);
        }
    }
}
