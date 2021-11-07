
using System;
using System.Collections.Generic;
using CinemaManagerApi.Models;

namespace CinemaManagerApi.Repositories
{
  public interface ILoginRepository<T>
  {
    T login(string login, string password);
    string DoesLoginExists(string login);
  }
}