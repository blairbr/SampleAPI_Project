using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticeWebApi.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> AddUser(User user)
        {
            if (user is null) throw new ArgumentNullException(nameof(user));
            ValidateUser(user);

            user.Id = Guid.NewGuid().ToString();
            await _userRepository.AddUser(user);

            return user;
        }

        public async Task DeleteUser(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentNullException(nameof(id));

            await _userRepository.DeleteUser(id);
        }

        public async Task<User> FindUserById(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentNullException(nameof(id));

            return await _userRepository.FindUserById(id);
        }

        public async Task<IEnumerable<User>> GetAllUsers() => await _userRepository.GetAllUsers();

        public async Task UpdateUser(User user)
        {
            if (user is null) throw new ArgumentNullException(nameof(user));
            if (string.IsNullOrWhiteSpace(user.Id)) throw new ArgumentException($"{nameof(user.Id)} cannot be null or white space");
            ValidateUser(user);

            await _userRepository.UpdateUser(user);
        }

        private void ValidateUser(User user)
        {
            if (string.IsNullOrWhiteSpace(user.FirstName)) throw new ArgumentException($"{nameof(user.FirstName)} cannot be null or white space");
            if (string.IsNullOrWhiteSpace(user.LastName)) throw new ArgumentException($"{nameof(user.LastName)} cannot be null or white space");
            if (string.IsNullOrWhiteSpace(user.Email)) throw new ArgumentException($"{nameof(user.Email)} cannot be null or white space");
            if (string.IsNullOrWhiteSpace(user.Address)) throw new ArgumentException($"{nameof(user.Address)} cannot be null or white space");
            if (string.IsNullOrWhiteSpace(user.City)) throw new ArgumentException($"{nameof(user.City)} cannot be null or white space");
            if (string.IsNullOrWhiteSpace(user.State)) throw new ArgumentException($"{nameof(user.State)} cannot be null or white space");
            if (string.IsNullOrWhiteSpace(user.Zip)) throw new ArgumentException($"{nameof(user.Zip)} cannot be null or white space");
        }
    }
}
