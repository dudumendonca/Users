using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace User.Models
{
    public class Usuario
    {
        [Key]
        public BigInteger UserId { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(100, ErrorMessage = "Este campo deve conter entre 1 e 100 caracteres")]
        [MinLength(1, ErrorMessage = "Este campo deve conter entre 1 e 100 caracteres")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(1, ErrorMessage = "Este campo deve conter 1 caracter")]
        [MinLength(1, ErrorMessage = "Este campo deve conter 1 caracter")]
        public char UserGender { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(254, ErrorMessage = "Este campo deve conter entre 1 e 254 caracteres")]
        [MinLength(1, ErrorMessage = "Este campo deve conter entre 1 e 254 caracteres")]
        [EmailAddress]
        // Definir como unico
        public string UserMainEmail { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(20, ErrorMessage = "Este campo deve conter entre 1 e 20 caracteres")]
        [MinLength(1, ErrorMessage = "Este campo deve conter entre 1 e 20 caracteres")]
        public string UserPassword { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public DateTime UserBirthDate { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string UserCpf { get; set; }
        public DateTime UserFirstLoginDate { get; set; }
        public DateTime UserDeletedDate { get; set; }
        public BigInteger UserDeletedUser { get; set; }
        public int CustomerId { get; set; }
        public int DepartmentId { get; set; }
        public int CargoId { get; set; }
        public int ProfileId { get; set; }
        public int UserStatusId { get; set; }

        public string Role { get; set; }
    }
}
