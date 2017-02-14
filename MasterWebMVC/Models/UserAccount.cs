using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MasterWebMVC.Models
{
    public class UserAccount
    {
        [Key]
        public int UserID { get; set; }

        [Display(Name = "Nombre(s): ")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        public string FirstName { get; set; }

        [Display(Name = "Apellido: ")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        public string LastName { get; set; }

        [Display(Name = "Correo electrónico: ")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [EmailAddress(ErrorMessage = "Formato de correo no válido.")]
        public string Email { get; set; }

        [Display(Name = "Nombre de usuario: ")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        public string Username { get; set; }

        [Display(Name = "Contraseña: ")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirmar contraseña: ")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [Compare("Password", ErrorMessage = "Las contraseñas no coinciden.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}