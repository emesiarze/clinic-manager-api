using clinic_manager_api.Models;
using clinic_manager_api.Repositories;

namespace clinic_manager_api.Controllers
{
  public class DiagnosesController : GenericController<Diagnose>
  {
    public DiagnosesController(IRepository<Diagnose> repository) : base(repository) { }
  }
}