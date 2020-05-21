using System;

namespace PracticeWebApi
{
    public class User : ICloneable
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public object Clone()
        {
            return new User
            {
                Id = Id,
                FirstName = FirstName,
                LastName = LastName,
                Email = Email,
                Address = Address,
                City = City,
                State = State,
                Zip = Zip
            };
        }
    }
}
