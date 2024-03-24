namespace KidsFlixSystem.Data.Configurations
{
    using KidsFlixSystem.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;


    public class ActorInMovieEntityConfiguration : IEntityTypeConfiguration<ActorInMovie>
    {
        public void Configure(EntityTypeBuilder<ActorInMovie> builder)
        {
            builder
               .HasKey(a => new { a.ActorId, a.MovieId });

            // Configure one-to-many relationship between Actor and ActorInMovie
            builder
                .HasOne(a => a.Actor)
                .WithMany(a => a.ActorInMovies)
                .HasForeignKey(a => a.ActorId);

            // Configure one-to-many relationship between Movie and ActorInMovie
            builder
                .HasOne(m => m.Movie)
                .WithMany(m => m.ActorInMovies)
                .HasForeignKey(m => m.MovieId);
        }
    }
}
