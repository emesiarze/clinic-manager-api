using cinema_manager_api.Models;
using cinema_manager_api.Repositories;

namespace cinema_manager_api.Controllers
{
  public class HallsController : GenericController<Hall>
  {
    public HallsController(IRepository<Hall> repository) : base(repository) { }
  }
}