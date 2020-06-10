using System.ComponentModel.DataAnnotations;

namespace UserDomain.Models
{
    public class UserEmail : Entity
    {
        [Key]
        public long UserEmailId { get; set; }
        public string UserMail { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        public int EmailTypeId { get; set; }
        public EmailType EmailType { get; set; }
    }
}