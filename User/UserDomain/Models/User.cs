using System;
using System.Collections.Generic;

namespace UserDomain.Models
{
    public class User : Entity
    {
        //public User(long userId, string userName, string userGender, string userMainEmail, string userPassword, DateTime userBirthDate, string userCpf, DateTime? userFirstLoginDate, DateTime? userDeletedDate, long? userDeletedUser, int customerId, int departmentId, int cargoId, int profileId, int userStatusId, string role)
        //{
        //    UserId = userId;
        //    UserName = userName;
        //    UserGender = userGender;
        //    UserMainEmail = userMainEmail;
        //    UserPassword = userPassword;
        //    UserBirthDate = userBirthDate;
        //    UserCpf = userCpf;
        //    UserFirstLoginDate = userFirstLoginDate;
        //    UserDeletedDate = null;
        //    UserDeletedUser = null;
        //    CustomerId = customerId;
        //    DepartmentId = departmentId;
        //    CargoId = cargoId;
        //    ProfileId = profileId;
        //    UserStatusId = userStatusId;
        //    Role = role;
        //}

        public long UserId { get; private set; }
        public string UserName { get; private set; }
        public string UserGender { get; private set; }
        public string UserMainEmail { get; private set; }
        public string UserPassword { get; private set; }
        public DateTime UserBirthDate { get; private set; }
        public string UserCpf { get; private set; }
        public DateTime? UserFirstLoginDate { get; private set; }
        public DateTime? UserDeletedDate { get; private set; }
        public long? UserDeletedUser { get; private set; }
        public int CustomerId { get; private set; }
        public int DepartmentId { get; private set; }
        public int CargoId { get; private set; }
        public int ProfileId { get; private set; }
        public int UserStatusId { get; private set; }
        public string Role { get; private set; }
        public IEnumerable<UserAddress> Addresses { get; private set; }     
    }
}