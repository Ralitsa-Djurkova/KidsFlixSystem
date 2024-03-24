namespace KidsFlixSystem.Data.Models
{
    using Microsoft.EntityFrameworkCore;

    using System.ComponentModel.DataAnnotations.Schema;

    using System.ComponentModel.DataAnnotations;

    using static KidsFlixSystem.Common.EntityValidationConstants.Director;
    public class Director
    {
        [Key]
        [Comment("Id for a Director")]
        public int Id { get; set; }
        [Required]
        [MaxLength(DirectorFullNameMaxLength)]
        [Comment("Full name for a director")]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [Comment("Date of birth for an director")]
        public DateTime DiteOfBirth { get; set; }

        [Required]
        [MaxLength(DirectorBiographyMaxLength)]
        [Comment("Biography")]
        public string Biography { get; set; } = string.Empty;

        [Required]
        public string PhotoUrl { get; set; } = string.Empty;

        public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}
