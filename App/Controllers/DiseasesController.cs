using clinic_manager_api.Models;
using clinic_manager_api.Repositories;

namespace clinic_manager_api.Controllers
{
  public class DiseasesController : GenericController<Symptom>
  {
    public DiseasesController(IRepository<Symptom> repository) : base(repository) { }
  }
}