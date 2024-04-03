namespace KidsFlixSystem.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;

    public class ApplicationUser : IdentityUser<Guid>
    {

        public ApplicationUser()
        {
            this.Reviews = new List<Review>();
        }

        [Display(Name = "Full name")]
        public string FullName { get; set; }
        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
