using System.Threading.Tasks;
using System.Collections.Generic;
using FamilyBudget.Entities;
using FamilyBudget.Api.Services.Interfaces;

namespace FamilyBudget.Api.Services
{
    public class UserServices : IUserService
    {
        Task<IEnumerable<User>> GetAll()
        {
            var users = new List<User>();
            return users;
        }
        Task<User> GetById(int id)
        {
            return new User{Id = id};

        }
        Task<User> Add(User user)
        {
            return user;
        }
    }
}