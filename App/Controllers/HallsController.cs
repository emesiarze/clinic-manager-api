using clinic_manager_api.Models;
using clinic_manager_api.Repositories;

namespace clinic_manager_api.Controllers
{
  public class HallsController : GenericController<Hall>
  {
    public HallsController(IRepository<Hall> repository) : base(repository) { }
  }
}