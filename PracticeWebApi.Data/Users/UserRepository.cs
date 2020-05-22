using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticeWebApi.Data.Users
{
    public class UserRepository : IUserRepository
    {
        public Task AddUser(UserDataEntity user)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteUser(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<UserDataEntity> FindUserById(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<UserDataEntity>> GetAllUsers()
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateUser(UserDataEntity user)
        {
            throw new System.NotImplementedException();
        }
    }
}
