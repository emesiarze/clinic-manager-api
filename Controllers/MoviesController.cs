using CinemaManagerApi.Models;
using CinemaManagerApi.Repositories;

namespace CinemaManagerApi.Controllers
{
  public class MoviesController : GenericController<Movie>
  {
    public MoviesController(IRepository<Movie> repository) : base(repository) { }
  }
}