
using System;
using System.Collections.Generic;
using cinema_manager_api.Models;

namespace cinema_manager_api.Repositories
{
  public interface ILoginRepository<T>
  {
    T login(string login, string password);
    string DoesLoginExists(string login);
  }
}