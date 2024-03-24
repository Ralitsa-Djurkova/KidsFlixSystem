using KidsFlixSystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KidsFlixSystem.Data.Configurations
{
    public class MovieEntityConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.Property(m => m.CreatedOn)
                .HasDefaultValue(DateTime.UtcNow);
            builder
                 .HasOne(x => x.Director)
                 .WithMany(m => m.Movies)
                 .HasForeignKey(x => x.DirectorId)
                 .OnDelete(DeleteBehavior.Restrict);




            builder.HasData(this.GetMovies());


        }

        private Movie[] GetMovies()
        {
            ICollection<Movie> movies = new HashSet<Movie>();

            Movie movie;

            movie = new Movie()
            {
                Id = 1,
                Title = "Ratatouille",
                ReleaseDate = new DateTime(2007),
                Rating = 8.1,
                Duration = 111,
                Genre = "Comedy",
                Description = "A rat who can cook makes an unusual alliance with a young kitchen worker at a famous Paris restaurant.",
                TrailerUrl = "https://www.imdb.com/title/tt0382932/",
                DirectorId = 1

            };
            movies.Add(movie);
            movie = new Movie()
            {
                Id = 2,
                Title = "Zootopia",
                ReleaseDate = new DateTime(2016),
                Rating = 8.5,
                Duration = 106,
                Genre = "Comedy",
                Description = "n the city of Zootopia, a rookie bunny police officer named Judy Hopps teams up with a cynical fox con artist named Nick Wilde to solve" +
                " a mysterious case involving the disappearance of predators" +
                ". Along the way, they uncover a conspiracy that challenges the harmony of their diverse animal society.",
                TrailerUrl = "https://www.imdb.com/title/tt2948356/",
                DirectorId = 2
            };
            movies.Add(movie);
            return movies.ToArray();
        }
    }
}
