namespace KidsFlixSystem.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using System.Diagnostics;


    using KidsFlixSystem.Web.ViewModels.Home;
    using KidsFlixSystem.Services.Data.Interfaces;

    public class HomeController : Controller
    {
        private readonly IMovieService movieService;
        public HomeController(IMovieService movieService)
        {
            this.movieService = movieService;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<IndexViewModel> viewModel =
                await this.movieService.LastTwoMovie();
            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
