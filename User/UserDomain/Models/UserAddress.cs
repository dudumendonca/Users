namespace UserDomain.Models
{
    public class UserAddress
    {
        public UserAddress(long userAddressId, int userStreetNumber, string userStreetName, string userComplement, string userNeighborhood, string userCity, string userState, string userCountry, int userZipCode, long userId, int addressTypeId)
        {
            UserAddressId = userAddressId;
            UserStreetNumber = userStreetNumber;
            UserStreetName = userStreetName;
            UserComplement = userComplement;
            UserNeighborhood = userNeighborhood;
            UserCity = userCity;
            UserState = userState;
            UserCountry = userCountry;
            UserZipCode = userZipCode;
            UserId = userId;
            AddressTypeId = addressTypeId;
        }

        public long UserAddressId { get; private set; }
        public int UserStreetNumber { get; private set; }
        public string UserStreetName { get; private set; }
        public string UserComplement { get; private set; }
        public string UserNeighborhood { get; private set; }
        public string UserCity { get; private set; }
        public string UserState { get; private set; }
        public string UserCountry { get; private set; }
        public int UserZipCode { get; private set; }
        public long UserId { get; private set; }
        public User User { get; private set; }
        public int AddressTypeId { get; private set; }
        public AddressType AddressType { get; private set; }
    }
}