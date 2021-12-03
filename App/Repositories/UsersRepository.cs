using System;
using System.Collections.Generic;
using System.Linq;
using clinic_manager_api.Data;
using clinic_manager_api.Models;

namespace clinic_manager_api.Repositories
{
  public class UsersRepository : GenericRepository<User, UserDto>
  {
    public override List<User> items
    {
      get
      {
        return UsersData.items;
      }
    }

    public override IEnumerable<UserDto> GetAllItemsDto()
    {
      IEnumerable<User> users = base.GetAllItems();
      IEnumerable<UserDto> usersDto = users.Select(user => new UserDto(user)).ToList().FindAll((Predicate<UserDto>)(user => !user.isAdmin));

      return usersDto;
    }

    public override UserDto GetSingleItemDto(Guid id)
    {
      User user = base.GetSingleItem(id);
      return new UserDto(user);
    }
  }
}