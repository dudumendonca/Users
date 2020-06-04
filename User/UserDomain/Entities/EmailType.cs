namespace UserDomain.Entities
{
    public class EmailType
    {
        public EmailType(int emailTypeId, string emailTypeName)
        {
            EmailTypeId = emailTypeId;
            EmailTypeName = emailTypeName;
        }

        public int EmailTypeId { get; private set; }
        public string EmailTypeName { get; private set; }
    }
}