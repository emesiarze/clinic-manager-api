
using CinemaManagerApi.Models;
using CinemaManagerApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CinemaManagerApi.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class AuthController : ControllerBase
  {
    protected readonly ILoginRepository<User> repository;

    public AuthController(ILoginRepository<User> repository)
    {
      this.repository = repository;
    }

    [HttpGet]
    public Response<User> login(string login, string password)
    {
      User user = repository.login(login, password);
      Response<User> response = new Response<User>();
      response.data = user;
      response.isSuccess = user is not null;

      if (!response.isSuccess)
      {
        response.errorMessage = "not_found";
      }

      return response;
    }
  }
}