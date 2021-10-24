using CinemaManagerApi.Models;
using CinemaManagerApi.Repositories;

namespace CinemaManagerApi.Controllers
{
  public class SeansesController : GenericController<Seanse>
  {
    public SeansesController(IRepository<Seanse> repository) : base(repository) { }
  }
}