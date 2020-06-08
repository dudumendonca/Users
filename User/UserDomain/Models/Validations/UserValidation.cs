using FluentValidation;

namespace UserDomain.Models.Validations
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(c => c.UserName)
                .NotEmpty().WithMessage("O campo {UserName} precisa ser fornecido")
                .Length(1, 150).WithMessage("O campo {UserName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(c => c.UserMainEmail)
                .NotEmpty().WithMessage("O campo {UserMainEmail} precisa ser fornecido")
                .Length(1, 254).WithMessage("O campo {UserMainEmail} precisa ter entre {MinLength} e {MaxLength} caracteres").EmailAddress();
        }
    }
}
