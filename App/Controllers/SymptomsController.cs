using clinic_manager_api.Models;
using clinic_manager_api.Repositories;

namespace clinic_manager_api.Controllers
{
  public class SymptomsController : GenericController<Symptom>
  {
    public SymptomsController(IRepository<Symptom> repository) : base(repository) { }
  }
}