namespace KidsFlixSystem.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static KidsFlixSystem.Common.EntityValidationConstants.Movie;
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MovieTitleMaxLength)]
        [Comment("Title movie")]
        public string Title { get; set; } = string.Empty;

        [Required]

        [Comment("Date on Release")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Range(1, 10)]
        public double Rating { get; set; }
        public int Duration { get; set; }

        public DateTime CreatedOn { get; set; }
        public string Genre { get; set; } = string.Empty;

        [MaxLength(MovieDescriptionMaxLength)]
        [Comment("Description for the movie")]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string TrailerUrl { get; set; } = string.Empty;

        [Required]
        public int DirectorId { get; set; }
        [ForeignKey(nameof(DirectorId))]
        public Director Director { get; set; } = null!;

        public ICollection<ActorInMovie> ActorInMovies { get; set; } = new List<ActorInMovie>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
