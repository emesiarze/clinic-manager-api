using clinic_manager_api.Models;
using clinic_manager_api.Repositories;

namespace clinic_manager_api.Controllers
{
  public class SeansesController : GenericController<Diagnose>
  {
    public SeansesController(IRepository<Diagnose> repository) : base(repository) { }
  }
}