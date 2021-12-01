
using clinic_manager_api.Models;
using clinic_manager_api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace clinic_manager_api.Controllers
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

    [HttpGet("login-check")]
    public Response<string> DoesLoginExists(string login)
    {
      string result = this.repository.DoesLoginExists(login);
      Response<string> response = new Response<string>();

      response.isSuccess = result != "error";
      response.data = result != "error" ? result : null;

      return response;
    }
  }
}