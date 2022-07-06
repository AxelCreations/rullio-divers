using System.ComponentModel.DataAnnotations;

namespace RullioDivers.App.Data.DTOs
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string Names { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string LastNames { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        [RegularExpression(@"^[^\s\,]*$", ErrorMessage = "No se permiten espacios en blanco")]
        [EmailAddress(ErrorMessage = "Debe ingresar un correo válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public int DiverSchoolID { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public string License { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public string LicenseImage { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[#$^+=!*()@%&]).{8,45}$", ErrorMessage = "Contraseña debe tener mayúsculas, minúsculas, caracter especial y minimo 8 caracteres")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Compare("Password", ErrorMessage = "Clave no coincide")]
        public string PasswordRepeat { get; set; }
    }
}