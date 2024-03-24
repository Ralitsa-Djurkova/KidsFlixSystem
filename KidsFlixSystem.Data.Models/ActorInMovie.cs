namespace KidsFlixSystem.Data.Models
{
    public class ActorInMovie
    {

        public int ActorId { get; set; }

        public Actor Actor { get; set; } = null!;
        public int MovieId { get; set; }

        public Movie Movie { get; set; } = null!;

        public Guid UserId { get; set; }

        public virtual ApplicationUser? Reviewer { get; set; }
    }
}
