using CinemaManagerApi.Models;
using CinemaManagerApi.Repositories;

namespace CinemaManagerApi.Controllers
{
  public class HallsController : GenericController<Hall>
  {
    public HallsController(IRepository<Hall> repository) : base(repository) { }
  }
}