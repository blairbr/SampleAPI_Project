using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticeWebApi.Services
{
    public interface IUserRepository
    {
        Task DeleteUser(string id);
        Task UpdateUser(User user);
        Task AddUser(User user);
        Task<User> FindUserById(string id);
        Task<IList<User>> GetAllUsers();
    }
}
