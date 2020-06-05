namespace UserDomain.Models
{
    public class AddressType
    {
        public AddressType(int addressTypeId, string addressTypeName)
        {
            AddressTypeId = addressTypeId;
            AddressTypeName = addressTypeName;
        }

        public int AddressTypeId { get; private set; }
        public string AddressTypeName { get; private set; }
    }
}