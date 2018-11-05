namespace proyecto_multi.Models
{
    public class camp_usuario
    {
        public usuario usuario { get; set; }
        public Campaña Campaña { get; set; }
        public int CampañaId{ get; set; }
        public int UsuarioId { get; set; }
        public int montoDonacion { get; set; }
    }
}