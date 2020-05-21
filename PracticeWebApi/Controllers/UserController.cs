﻿using Microsoft.AspNetCore.Mvc;
using PracticeWebApi.Services;
using System;
using System.Threading.Tasks;

namespace PracticeWebApi.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("/user")]
        public async Task<IActionResult> AddUser([FromBody]User user)
        {
            try
            {
                var addedUser = await _userService.AddUser(user);
                return Ok(addedUser);
            }
            catch(Exception exception)
            {
                return (BadRequest($"Add user failed due to {exception.Message}"));
            }
        }

        [HttpPut("/user")]
        public async Task<IActionResult> UpdateUser([FromBody]User user)
        {
            try
            {
                await _userService.UpdateUser(user);
                return Ok();
            }
            catch (Exception exception)
            {
                return (BadRequest($"Update user failed due to {exception.Message}"));
            }
        }

        [HttpDelete("/user/{id}")]
        public async Task<IActionResult> DeleteUser([FromRoute]string id)
        {
            try
            {
                await _userService.DeleteUser(id);
                return Ok();
            }
            catch (Exception exception)
            {
                return (BadRequest($"Delete user failed due to {exception.Message}"));
            }
        }

        [HttpGet("/user")]
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
               var users = await _userService.GetAllUsers();
                return Ok(users);
            }
            catch (Exception exception)
            {
                return (BadRequest($"Find all users failed due to {exception.Message}"));
            }
        }

        [HttpGet("/user/{id}")]
        public async Task<IActionResult> FindUserById([FromRoute]string id)
        {
            try
            {
                var user = await _userService.FindUserById(id);
                return Ok(user);
            }
            catch (Exception exception)
            {
                return (BadRequest($"Find user by id failed due to {exception.Message}"));
            }
        }
    }
}