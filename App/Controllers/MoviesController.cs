using clinic_manager_api.Models;
using clinic_manager_api.Repositories;

namespace clinic_manager_api.Controllers
{
  public class MoviesController : GenericController<Movie>
  {
    public MoviesController(IRepository<Movie> repository) : base(repository) { }
  }
}