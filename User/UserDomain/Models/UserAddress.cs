namespace UserDomain.Models
{
    public class UserAddress : Entity
    {
        public long UserAddressId { get; set; }
        public int UserStreetNumber { get; set; }
        public string UserStreetName { get; set; }
        public string UserComplement { get; set; }
        public string UserNeighborhood { get; set; }
        public string UserCity { get; set; }
        public string UserState { get; set; }
        public string UserCountry { get; set; }
        public int UserZipCode { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        public int AddressTypeId { get; set; }
        public AddressType AddressType { get; set; }
    }
}