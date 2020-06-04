namespace UserDomain.Entities
{
    public class UserEmail
    {
        public UserEmail(int userEmailId, string userMail, int userId, User user, int emailTypeId, EmailType emailType)
        {
            UserEmailId = userEmailId;
            UserMail = userMail;
            UserId = userId;
            User = user;
            EmailTypeId = emailTypeId;
            EmailType = emailType;
        }

        public int UserEmailId { get; private set; }
        public string UserMail { get; private set; }
        public int UserId { get; private set; }
        public User User { get; private set; }
        public int EmailTypeId { get; private set; }
        public EmailType EmailType { get; private set; }
    }
}