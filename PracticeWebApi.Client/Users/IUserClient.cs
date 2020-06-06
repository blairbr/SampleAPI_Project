using PracticeWebApi.CommonClasses.Users;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticeWebApi.Client.Users
{
    public interface IUserClient
    { 
        Task<User> FindUserById(string id);
        Task<IEnumerable<User>> GetAllUsers();
        Task RegisterNewUser(User user);
        Task DeleteUser(string id);
        Task UpdateUser(User user);
    }
}
