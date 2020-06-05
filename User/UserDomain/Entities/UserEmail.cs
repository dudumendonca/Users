namespace UserDomain.Entities
{
    public class UserEmail
    {
        public UserEmail(int userEmailId, string userMail, int userId,  int emailTypeId)
        {
            UserEmailId = userEmailId;
            UserMail = userMail;
            UserId = userId;
            EmailTypeId = emailTypeId;
        }

        public int UserEmailId { get; private set; }
        public string UserMail { get; private set; }
        public int UserId { get; private set; }
        public User User { get; private set; }
        public int EmailTypeId { get; private set; }
        public EmailType EmailType { get; private set; }
    }
}