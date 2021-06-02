using System;

namespace NotiticationApi.Models
{
    public class CustomerComException
    {
        public string Name { get; }
        public string Email { get; }

        //To swagger
        public CustomerComException()
        {}

        public CustomerComException(string name, string email)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new InvalidOperationException("Name cannot be empty.");
            }
            if (!email.Contains("@"))
            {
                throw new InvalidOperationException("Invalid email.");
            }
        }
    }
}
