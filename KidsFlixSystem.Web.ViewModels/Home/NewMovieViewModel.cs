using System.ComponentModel.DataAnnotations;

namespace KidsFlixSystem.Web.ViewModels.Home
{
    public class NewMovieViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Movie name")]
        [Required(ErrorMessage = "Name is required")]
        public string Title { get; set; }= string.Empty;
        [Display(Name = "Movie description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; } = string.Empty;
        [Display(Name = "Movie poster URL")]
        [Required(ErrorMessage = "Movie poster URL is required")]
        public string ImgUrl { get; set; } = string.Empty;
        [Display(Name = "Movie start date")]
        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Movie end date")]
        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Select actor(s)")]
        [Required(ErrorMessage = "Movie actor(s) is required")]
        public List<int> ActorsId { get; set; } = new List<int>();
        [Display(Name = "Select a producer")]
        [Required(ErrorMessage = "Movie producer is required")]
        public int ProducerId { get; set; }
    }
}
