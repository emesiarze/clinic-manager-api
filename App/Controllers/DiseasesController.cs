using clinic_manager_api.Models;
using clinic_manager_api.Repositories;

namespace clinic_manager_api.Controllers
{
  public class DiseasesController : GenericController<Disease, DiseaseDto>
  {
    public DiseasesController(IRepository<Disease, DiseaseDto> repository) : base(repository) { }
  }
}