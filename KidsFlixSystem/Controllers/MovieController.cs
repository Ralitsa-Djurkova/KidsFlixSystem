namespace KidsFlixSystem.Controllers
{
    using KidsFlixSystem.Services.Data.Interfaces;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;


    [Authorize]
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            var allMovies = await _movieService.GetAllMoviesAsync();
            return View(allMovies);
        }
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var movieDetails = await _movieService.GetMovieById(id);
            return View(movieDetails);
        }
    }
}
