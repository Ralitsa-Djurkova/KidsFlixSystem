using KidsFlixSystem.Data.Models;
using KidsFlixSystem.Web.ViewModels.Home;

namespace KidsFlixSystem.Services.Data.Interfaces
{
    public interface IMovieService
    {
        Task<IEnumerable<IndexViewModel>> LastTwoMovie();
    }
}

