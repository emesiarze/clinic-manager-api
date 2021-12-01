using clinic_manager_api.Models;
using clinic_manager_api.Repositories;

namespace clinic_manager_api.Controllers
{
  public class HallsController : GenericController<Symptom>
  {
    public HallsController(IRepository<Symptom> repository) : base(repository) { }
  }
}