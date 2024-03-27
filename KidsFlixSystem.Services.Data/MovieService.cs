namespace KidsFlixSystem.Services.Data
{
    using KidsFlixSystem.Data;
    using KidsFlixSystem.Services.Data.Interfaces;
    using KidsFlixSystem.Web.ViewModels.Home;
    using Microsoft.EntityFrameworkCore;

    
    public class MovieService : IMovieService
    {
        private readonly KidsFlixDbContext context;

        public MovieService(KidsFlixDbContext dbContex)
        {
            context = dbContex;
        }
        public async Task<IEnumerable<IndexViewModel>> LastTwoMovie()
        {
            

            var lastTwoMovies = await this.context
                .Movies
                .OrderByDescending(x => x.ReleaseDate)
                .Take(2)
                .Select(x => new IndexViewModel()
                {
                    Id = x.Id,
                    Titel = x.Title,
                    ImageUrl = x.TrailerUrl
                })
                .ToArrayAsync();

            return lastTwoMovies;
        }
    }
}
