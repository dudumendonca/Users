namespace UserDomain.Models
{
    public class UserStatus : Entity
    {
        public int UserStatusId { get; set; }
        public int UserStatusName { get; set; }
        public User User { get; set; }
    }
}