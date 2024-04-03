namespace KidsFlixSystem.Services.Data
{
    using KidsFlixSystem.Data;
    using KidsFlixSystem.Data.Models;
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
        public async Task<List<Movie>> GetAllMoviesAsync()
        {
            List<Movie> movies = await context.Movies.ToListAsync();
            return movies;
        }
        public async Task AddNewMovieAsync(NewMovieViewModel model)
        {
            var newMovie = new Movie()
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Description,
                
            };

            await context.Movies.AddAsync(newMovie);
            await context.SaveChangesAsync();

            foreach (var actorId in model.ActorsId)
            {
                var newActorMovie = new ActorInMovie()
                {
                    MovieId = newMovie.Id,
                    ActorId = actorId
                };
                await context.ActorInMovies.AddAsync(newActorMovie);
            }
            await context.SaveChangesAsync();
        }
        public async Task<Movie> GetMovieById(int id)
        {
            var movieDetails = await context.Movies
                .Include(m => m.ActorInMovies).ThenInclude(m => m.Actor)
                .FirstOrDefaultAsync(n=>n.Id == id);

            if(movieDetails == null)
            {
                throw new Exception($"Movie with id{id} can not be found!");
            }

            return movieDetails;
        }
        public async Task UpdateMovie(NewMovieViewModel model)
        {
            var movie = await context.Movies.FirstOrDefaultAsync(x => x.Id == model.Id);

            if(movie != null)
            {
                movie.Title = model.Title;
                movie.Description = model.Description;
                movie.TrailerUrl = model.ImgUrl;
                movie.DirectorId = model.ProducerId;
                movie.CreatedOn = model.StartDate;
                    
                await context.SaveChangesAsync();
            }

            var existingActorId = context.ActorInMovies.Where(x => x.MovieId == model.Id).ToList();
            context.ActorInMovies.AddRange(existingActorId);
            await context.SaveChangesAsync();

            foreach (var actorId in model.ActorsId)
            {
                var newActorMovie = new ActorInMovie()
                {
                    MovieId = model.Id,
                    ActorId = actorId,
                };

                await context.ActorInMovies.AddRangeAsync(newActorMovie);
            }

            await context.SaveChangesAsync();
        }
       
    }
}
