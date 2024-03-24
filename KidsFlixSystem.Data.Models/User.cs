namespace KidsFlixSystem.Data.Models
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.ComponentModel.DataAnnotations;

    using static KidsFlixSystem.Common.EntityValidationConstants.User;
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(MaxLengthPhoneNumber)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        public Guid UserId { get; set; }
        public virtual ApplicationUser UserIdent { get; set; } = null!;
    }
}
