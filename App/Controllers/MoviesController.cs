using clinic_manager_api.Models;
using clinic_manager_api.Repositories;

namespace clinic_manager_api.Controllers
{
  public class MoviesController : GenericController<Symptom>
  {
    public MoviesController(IRepository<Symptom> repository) : base(repository) { }
  }
}