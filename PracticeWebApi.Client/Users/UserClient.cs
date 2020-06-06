using Newtonsoft.Json;
using PracticeWebApi.CommonClasses.Users;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWebApi.Client.Users
{
    public class UserClient : IUserClient
    {
        //to do create a base url constant

        public Task DeleteUser(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> FindUserById(string id)
        {
            var getRequest = new HttpRequestMessage(HttpMethod.Get, $"https://localhost:44335/user/{id}");
            using (var client = new HttpClient())
            {
                var response = await client.SendAsync(getRequest);
                var stringResponse = await response.Content.ReadAsStringAsync();
                var user = JsonConvert.DeserializeObject<User>(stringResponse);

                return user;
            }
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            var getRequest = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44335/user");
            using (var client = new HttpClient()) //disposes it outside of these using. using statement uses the IDisposeable interface, so it contains the Dispose method. A "Disposable object" implements IDisposable and wrappign it in the using statment means you dont have to manage the resource, HTTP client will clean up for you
            {
                var response = await client.SendAsync(getRequest);
                var stringResponse = await response.Content.ReadAsStringAsync();
                var users = JsonConvert.DeserializeObject<IEnumerable<User>>(stringResponse);

                return users;
            }
        }

        public async Task RegisterNewUser(User user)
        {
            var postRequest = new HttpRequestMessage(HttpMethod.Post, "https://localhost:44335");
            var stringRequest = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
            postRequest.Content = stringRequest;

            using (var client = new HttpClient()) 
            {
                await client.SendAsync(postRequest);
            }  //should return user?

        }

        public Task UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
