using clinic_manager_api.Models;
using clinic_manager_api.Repositories;

namespace clinic_manager_api.Controllers
{
  public class SeansesController : GenericController<Seanse>
  {
    public SeansesController(IRepository<Seanse> repository) : base(repository) { }
  }
}