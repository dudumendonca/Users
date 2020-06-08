using System;
using System.ComponentModel.DataAnnotations;

namespace UserApi.ViewModels
{
    public class UserViewModel
    {
        [Key]
        public long UserId { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(150, ErrorMessage = "O campo {0} precisa ter entre {1} e {150} caracteres", MinimumLength = 2)]
        public string UserName { get; private set; }
        public string UserGender { get; private set; }
        public string UserMainEmail { get; private set; }
        public string UserPassword { get; private set; }
        public DateTime UserBirthDate { get; private set; }
        public string UserCpf { get; private set; }
        //public DateTime? UserFirstLoginDate { get; private set; }
        //public DateTime? UserDeletedDate { get; private set; }
        //public long? UserDeletedUser { get; private set; }
        //public int CustomerId { get; private set; }
        //public int DepartmentId { get; private set; }
        //public int CargoId { get; private set; }
        //public int ProfileId { get; private set; }
        //public int UserStatusId { get; private set; }
        //public string Role { get; private set; }
    }
}
