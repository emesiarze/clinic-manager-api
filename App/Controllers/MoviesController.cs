using cinema_manager_api.Models;
using cinema_manager_api.Repositories;

namespace cinema_manager_api.Controllers
{
  public class MoviesController : GenericController<Movie>
  {
    public MoviesController(IRepository<Movie> repository) : base(repository) { }
  }
}