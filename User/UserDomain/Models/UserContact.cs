namespace UserDomain.Models
{
    public class UserContact
    {
        public UserContact(long userContactId, int userCountryRegion, int userDDD, int userPhoneNumber, int contactTypeId, long userId)
        {
            UserContactId = userContactId;
            UserCountryRegion = userCountryRegion;
            UserDDD = userDDD;
            UserPhoneNumber = userPhoneNumber;
            ContactTypeId = contactTypeId;
            UserId = userId;
        }

        public long UserContactId { get; private set; }
        public int UserCountryRegion { get; private set; }
        public int UserDDD { get; private set; }
        public int UserPhoneNumber { get; private set; }
        public int ContactTypeId { get; private set; }
        public ContactType ContactType { get; private set; }
        public long UserId { get; private set; }
        public User User { get; private set; }
    }
}