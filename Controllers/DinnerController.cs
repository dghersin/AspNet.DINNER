using AspNet.DINNER.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.DINNER.Controllers
{
    public class DinnerController : Controller
    {
        private readonly DinnerService _dinnerService;

        public DinnerController(DinnerService dinnerService)
        {
            _dinnerService = dinnerService;
        }

        public IActionResult Index()
        {
            var dinnerMenu = _dinnerService.GenerateDinnerMenu();
            return View(dinnerMenu);
        }
    }
}
