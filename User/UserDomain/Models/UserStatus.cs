namespace UserDomain.Models
{
    public class UserStatus
    {
        public UserStatus(int userStatusId, int userStatusName)
        {
            UserStatusId = userStatusId;
            UserStatusName = userStatusName;
        }

        public int UserStatusId { get; private set; }
        public int UserStatusName { get; private set; }

        public User User {get; set;}
    }
}