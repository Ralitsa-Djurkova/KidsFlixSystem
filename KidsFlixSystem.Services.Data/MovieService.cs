namespace KidsFlixSystem.Services.Data
{
    using KidsFlixSystem.Data;
    using KidsFlixSystem.Services.Data.Interfaces;
    using KidsFlixSystem.Web.ViewModels.Home;
    using System.Data.Entity;


    public class MovieService : IMovieService
    {
        private readonly KidsFlixDbContext _dbContext;

        public MovieService(KidsFlixDbContext dbContex)
        {
            _dbContext = dbContex;
        }
        public async Task<IEnumerable<IndexViewModel>> LastTwoMovie()
        {
            IEnumerable<IndexViewModel> lastTwoMovies = await this._dbContext
                .Movies
                .OrderByDescending(x => x.Id)
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
