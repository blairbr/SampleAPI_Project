﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeWebApi.Data.Users
{
    public class FakeUserRepository : IUserRepository
    {
        private IList<UserDataEntity> _users;

        public FakeUserRepository()
        {
            _users = new List<UserDataEntity>();
        }

        public Task AddUser(UserDataEntity user)
        {
            if (_users.Any(u => u.Id == user.Id)) throw new InvalidOperationException($"A user with id {user.Id} already exists");

            _users.Add(user);

            return Task.CompletedTask;
        }

        public Task DeleteUser(string id)
        {
            if (!_users.Any(user => user.Id == id)) throw new InvalidOperationException($"No user found with id {id}");

            _users = _users.Where(user => user.Id != id).ToList();

            return Task.CompletedTask;
        }

        public Task<UserDataEntity> FindUserById(string id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);

            if (user is null) throw new InvalidOperationException($"No user found with id {id}");

            return Task.FromResult(user);
        }

        public Task<IList<UserDataEntity>> GetAllUsers()
        {
            return Task.FromResult(_users);
        }

        public Task UpdateUser(UserDataEntity user)
        {
            DeleteUser(user.Id);

            _users.Add(user);

            return Task.CompletedTask;
        }
    }
}