using System;

namespace PracticeWebApi.CommonClasses
{
    public class ResourceNotFoundException : Exception
    {
        public ResourceNotFoundException(string message, Exception innerException = null) 
            : base(message, innerException) { }
    }
}
