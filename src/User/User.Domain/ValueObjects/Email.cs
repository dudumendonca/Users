using Flunt.Notifications;
using Flunt.Validations;

namespace Domain.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string email)
        {
            UserMainEmail = email;

            AddNotifications(new Contract()
             .Requires()
             .IsEmail(UserMainEmail, "Email", "O E-mail é inválido")
         );
        }

        public string UserMainEmail { get; private set; }

        public override string ToString() => UserMainEmail.ToString();
    }
}
