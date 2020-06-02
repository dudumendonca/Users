namespace User.Domain.ValueObjects
{
    public class Email
    {
        public Email(string email)
        {
            UserEmail = email;
        }

        public string UserEmail { get; private set; }

        public override string ToString() => UserEmail.ToString();
    }
}
