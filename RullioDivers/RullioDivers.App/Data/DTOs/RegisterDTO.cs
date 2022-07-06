using RullioDivers.DAL.Domain;
using System;
using System.ComponentModel.DataAnnotations;

namespace RullioDivers.App.Data.DTOs
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(50)]
        public string LastNames { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(20)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public int DiverSchoolID { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Compare("Password", ErrorMessage = "Clave no coincide")]
        public string PasswordRepeat { get; set; }
    }
}
