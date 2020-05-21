using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticeWebApi.Services
{
    public class UserRepository : IUserRepository
    {
        public Task AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUser(string id)
        {
            throw new NotImplementedException();
        }

        public Task<User> FindUserById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
