namespace KidsFlixSystem.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    using static KidsFlixSystem.Common.EntityValidationConstants.Actor;
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(ActorFullNameMaxLength)]
        [Comment("Actor full name")]
        public string FullName { get; set; } = string.Empty;

        [Required]
        public string PhotoUrl { get; set; } = string.Empty;

        public ICollection<ActorInMovie> ActorInMovies { get; set; } = new List<ActorInMovie>();


    }
}
