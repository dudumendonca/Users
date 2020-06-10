using System;
using System.Collections.Generic;

namespace UserDomain.Models
{
    public class User : Entity
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string UserGender { get; set; }
        public string UserMainEmail { get; set; }
        public string UserPassword { get; set; }
        public DateTime UserBirthDate { get; set; }
        public string UserCpf { get; set; }
        public DateTime? UserFirstLoginDate { get; set; }
        public DateTime? UserDeletedDate { get; set; }
        public long? UserDeletedUser { get; set; }
        public int CustomerId { get; set; }
        public int DepartmentId { get; set; }
        public int CargoId { get; set; }
        public int ProfileId { get; set; }
        public int UserStatusId { get; set; }
        public string Role { get; set; }
        public IEnumerable<UserAddress> Addresses { get; set; }
    }
}