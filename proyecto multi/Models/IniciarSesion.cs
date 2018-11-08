
using System;
using System.ComponentModel.DataAnnotations;


namespace proyecto_multi.Models
{
    public class IniciarSesion
    {
        [Required]//es requerido
        [EmailAddress]//es de tipo email
        public String Correo { get; set; }

        [Required]
        public String Password { get; set; }
    }
}