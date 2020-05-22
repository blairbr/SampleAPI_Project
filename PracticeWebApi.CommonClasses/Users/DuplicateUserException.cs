using System;

namespace PracticeWebApi.CommonClasses.Users
{
    public class DuplicateUserException : Exception
    {
        public DuplicateUserException(string message, Exception innerException = null)
            : base(message, innerException) { }
    }
}
