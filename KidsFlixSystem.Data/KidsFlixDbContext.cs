namespace KidsFlixSystem.Data
{
    using KidsFlixSystem.Data.Configurations;
    using KidsFlixSystem.Data.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using System.Reflection;

    public class KidsFlixDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public KidsFlixDbContext(DbContextOptions<KidsFlixDbContext> options)
            : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; } = null!;

        public DbSet<Actor> Actors { get; set; } = null!;

        public DbSet<Director> Directors { get; set; } = null!;

        public DbSet<Review> Reviews { get; set; } = null!;

        public DbSet<ActorInMovie> ActorInMovies { get; set; } = null!;
        public DbSet<User> ApplicationUsers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Assembly configAssembly = Assembly.GetAssembly(typeof(KidsFlixDbContext)) ??
                                       Assembly.GetExecutingAssembly();
            builder.ApplyConfigurationsFromAssembly(configAssembly);

            base.OnModelCreating(builder);
        }

    }
}
