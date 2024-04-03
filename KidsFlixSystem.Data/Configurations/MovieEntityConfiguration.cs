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
                TrailerUrl = "https://static.tvtropes.org/pmwiki/pub/images/ratatouille_dvd.png",
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
                TrailerUrl = "https://www.ft.com/__origami/service/image/v2/images/raw/http%3A%2F%2Fcom.ft.imagepublish.upp-prod-eu.s3.amazonaws.com%2Fafd7ab32-5517-11e6-9664-e0bdc13c3bef?source=next-article&fit=scale-down&quality=highest&width=700&dpr=1",
                DirectorId = 2
            };
            movies.Add(movie);
            return movies.ToArray();
        }
    }
}
