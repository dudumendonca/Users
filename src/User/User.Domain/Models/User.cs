using Domain.ValueObjects;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Domain.Models
{
    public class User : Notifiable
    {
        public User(string userName, char userGender, Email userMainEmail, string userPassword, DateTime userBirthDate, Document userCpf, DateTime userFirstLoginDate, int customerId, int departmentId, int cargoId, int profileId, int userStatusId, string role)
        {
            UserName = userName;
            UserGender = userGender;
            UserMainEmail = userMainEmail;
            UserPassword = userPassword;
            UserBirthDate = userBirthDate;
            UserCpf = userCpf;
            UserFirstLoginDate = userFirstLoginDate;
            CustomerId = customerId;
            DepartmentId = departmentId;
            CargoId = cargoId;
            ProfileId = profileId;
            UserStatusId = userStatusId;
            Role = role;

            AddNotifications(new Contract()
                 .Requires()
                 .HasMinLen(UserName, 3, "UserName", "O nome deve conter pelo menos 3 caracteres")
                 .HasMaxLen(UserName, 100, "UserName", "O nome deve conter no máximo 40 caracteres")
             );

        }

        [Key]
        public BigInteger UserId { get; private set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(100, ErrorMessage = "Este campo deve conter entre 1 e 100 caracteres")]
        [MinLength(1, ErrorMessage = "Este campo deve conter entre 1 e 100 caracteres")]
        public string UserName { get; private set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(1, ErrorMessage = "Este campo deve conter 1 caracter")]
        [MinLength(1, ErrorMessage = "Este campo deve conter 1 caracter")]
        public char UserGender { get; private set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(254, ErrorMessage = "Este campo deve conter entre 1 e 254 caracteres")]
        [MinLength(1, ErrorMessage = "Este campo deve conter entre 1 e 254 caracteres")]
        [EmailAddress]
        // Definir como unico
        public Email UserMainEmail { get; private set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(20, ErrorMessage = "Este campo deve conter entre 1 e 20 caracteres")]
        [MinLength(1, ErrorMessage = "Este campo deve conter entre 1 e 20 caracteres")]
        public string UserPassword { get; private set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public DateTime UserBirthDate { get; private set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public Document UserCpf { get; private set; }

        public DateTime UserFirstLoginDate { get; private set; }

        public DateTime UserDeletedDate { get; private set; }

        public BigInteger UserDeletedUser { get; private set; }

        public int CustomerId { get; private set; }

        public int DepartmentId { get; private set; }

        public int CargoId { get; private set; }

        public int ProfileId { get; private set; }

        public int UserStatusId { get; private set; }

        public string Role { get; private set; }
    }
}
