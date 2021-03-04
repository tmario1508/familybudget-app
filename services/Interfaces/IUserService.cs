using System.Threading.Tasks;
using System.Collections.Generic;
using FamilyBudget.Entities;

namespace FamilyBudget.Api.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(int id);
        Task<User> Add(User user);

    }
}