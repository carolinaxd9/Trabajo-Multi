using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace proyecto_multi.Models
{
    public class Campaña
    {
        public int CampañaId { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string informacion { get; set; }
        [Required]       
        public string distrito { get; set; }
        [Required]
        public int CantidadPersonas { get; set; }
        public string foto { get; set; }
        public string implementos { get; set; }
        public List<camp_usuario> camp_usuarios{get;set;}
    }
}