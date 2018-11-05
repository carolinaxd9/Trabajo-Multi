using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace proyecto_multi.Models
{
    public class usuario
    {
        public int UsuarioId { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public int Edad { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Contraseña { get; set; }
        [Required]
        public int celular { get; set; }
        [Required]
        public string distrito { get; set; }
        public List<camp_usuario> camp_usuarios{get;set;}
    }
}