using FluentValidation;

namespace NotiticationApi.Models
{
    public class CustomerValidator: AbstractValidator<CustomerComNotification>
    {
        public CustomerValidator()
        {
            RuleFor(a => a.Email)
                .NotEmpty()
                .EmailAddress()
                .WithMessage("Invalid email");

            RuleFor(a => a.Name)
                .NotEmpty()
                .WithMessage("Name cannot be empty");
        }
    }
}
