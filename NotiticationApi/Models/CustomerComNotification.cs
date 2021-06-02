namespace NotiticationApi.Models
{
    public class CustomerComNotification: Entity
    {
        public string Name { get; }
        public string Email { get; }

        //To swagger
        public CustomerComNotification()
        { }

        public CustomerComNotification(string name, string email)
        {
            Id = System.Guid.NewGuid();
            Name = name;
            Email = email;

            Validate(this, new CustomerValidator());
        }
    }
}
