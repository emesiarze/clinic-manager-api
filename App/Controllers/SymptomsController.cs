using clinic_manager_api.Models;
using clinic_manager_api.Repositories;

namespace clinic_manager_api.Controllers
{
  public class SymptomsController : GenericController<Symptom, Symptom>
  {
    public SymptomsController(IRepository<Symptom, Symptom> repository) : base(repository) { }
  }
}