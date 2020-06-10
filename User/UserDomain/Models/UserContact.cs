namespace UserDomain.Models
{
    public class UserContact : Entity
    {
        public long UserContactId { get; set; }
        public int UserCountryRegion { get; set; }
        public int UserDDD { get; set; }
        public int UserPhoneNumber { get; set; }
        public int ContactTypeId { get; set; }
        public ContactType ContactType { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
    }
}