using CinemaManagerApi.Models;
using CinemaManagerApi.Repositories;

namespace CinemaManagerApi.Controllers
{
  public class ReservationsController : GenericController<Reservation>
  {
    public ReservationsController(IRepository<Reservation> repository) : base(repository) { }
  }
}