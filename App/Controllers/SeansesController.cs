using cinema_manager_api.Models;
using cinema_manager_api.Repositories;

namespace cinema_manager_api.Controllers
{
  public class SeansesController : GenericController<Seanse>
  {
    public SeansesController(IRepository<Seanse> repository) : base(repository) { }
  }
}