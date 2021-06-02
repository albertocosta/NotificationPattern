using System;

namespace NotiticationApi.Models
{
    public class Customer
    {
        public string Name { get; }
        public string Email { get; }

        //To swagger
        public Customer()
        {}

        public Customer(string name, string email)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new InvalidOperationException("Name cannot be empty");
            }
            if (!email.Contains("@"))
            {
                throw new InvalidOperationException("Invalid email");
            }
        }
    }
}
