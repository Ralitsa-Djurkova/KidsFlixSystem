namespace KidsFlixSystem.Web.ViewModels.Home
{
    public class IndexViewModel
    {
        public int Id { get; set; }
        public string Titel { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;

        public DateOnly Release { get; set; }
    }
}
