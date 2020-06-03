
namespace UserDomain.ValueObjects
{
    public class Email
    {
        public Email(string email)
        {
            UserMainEmail = email;

         //   AddNotifications(new Contract()
         //    .Requires()
         //    .IsEmail(UserMainEmail, "Email", "O E-mail é inválido")
         //);
        }

        public string UserMainEmail { get; private set; }

        public override string ToString() => UserMainEmail.ToString();
    }
}
