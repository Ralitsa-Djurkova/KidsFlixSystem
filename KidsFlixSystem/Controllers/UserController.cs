namespace KidsFlixSystem.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class UserController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
