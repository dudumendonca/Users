namespace UserDomain.Entities
{
    public class ContactType
    {
        public ContactType(int contactTypeId, string contactTypeName)
        {
            ContactTypeId = contactTypeId;
            ContactTypeName = contactTypeName;
        }

        public int ContactTypeId { get; private set; }
        public string  ContactTypeName { get; private set; }
    }
}