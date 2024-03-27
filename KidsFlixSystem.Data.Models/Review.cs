namespace KidsFlixSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static KidsFlixSystem.Common.EntityValidationConstants.Review;

    public class Review
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(ReviewCommentMaxLength)]
        public string Comment { get; set; } = string.Empty;
        [Required]
        public DateTime DateCreated { get; set; }
        [Required]
        public int MovieId { get; set; }
        [ForeignKey(nameof(MovieId))]
        public Movie Movie { get; set; } = null!;
        [Required]
        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;



    }
}
