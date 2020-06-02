using System.Numerics;
using User.Domain.Enums;

namespace Domain.Models
{
    public class UserAddress
    {
        public UserAddress(BigInteger userId, int userStreetNumber, string userStreetName, string userComplement, string userNeighborhood, string userCity, char userState, string userCountry, int userZipCode, EAddressType addressTypeId)
        {
            UserId = userId;
            UserStreetNumber = userStreetNumber;
            UserStreetName = userStreetName;
            UserComplement = userComplement;
            UserNeighborhood = userNeighborhood;
            UserStreetCity = userCity;
            UserStreetState = userState;
            UserCountry = userCountry;
            UserZipCode = userZipCode;
            AddressTypeId = addressTypeId;
        }

        public BigInteger UserAddressId { get; set; }

        public BigInteger UserId { get; set; }

        public int UserStreetNumber { get; set; }

        public string UserStreetName { get; set; }

        public string UserComplement { get; set; }

        public string UserNeighborhood { get; set; }

        public string UserStreetCity { get; set; }

        public char UserStreetState { get; set; }

        public string UserCountry { get; set; }

        public int UserZipCode { get; set; }

        public EAddressType AddressTypeId { get; set; }

        public override string ToString()
        {
            return $"{UserStreetName}, {UserStreetNumber} - {UserStreetCity}/{UserStreetState}";
        }
    }
}
