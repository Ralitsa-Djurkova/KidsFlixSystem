namespace KidsFlixSystem.Data.Models
{
    using Microsoft.AspNetCore.Identity;


    public class ApplicationUser : IdentityUser<Guid>
    {

        public ApplicationUser()
        {
            this.Reviews = new List<Review>();
        }


        public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
