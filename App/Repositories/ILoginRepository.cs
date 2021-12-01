
using System;
using System.Collections.Generic;
using clinic_manager_api.Models;

namespace clinic_manager_api.Repositories
{
  public interface ILoginRepository<T>
  {
    T login(string login, string password);
    string DoesLoginExists(string login);
  }
}