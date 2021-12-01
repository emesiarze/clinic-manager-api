using clinic_manager_api.Models;
using clinic_manager_api.Repositories;

namespace clinic_manager_api.Controllers
{
  public class DiagnosesController : GenericController<Diagnose, DiagnoseDto>
  {
    public DiagnosesController(IRepository<Diagnose, DiagnoseDto> repository) : base(repository) { }
  }
}