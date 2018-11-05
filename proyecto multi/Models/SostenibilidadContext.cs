using  Microsoft.EntityFrameworkCore;
namespace proyecto_multi.Models
{
    public class SostenibilidadContext : DbContext
    {
        public SostenibilidadContext(DbContextOptions<SostenibilidadContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<camp_usuario>().HasKey(pc=> new{pc.UsuarioId,pc.CampañaId});
            
            modelbuilder.Entity<camp_usuario>()
            .HasOne(pc=>pc.usuario)
            .WithMany(p=>p.camp_usuarios)
            .HasForeignKey(pc=>pc.UsuarioId);

            modelbuilder.Entity<camp_usuario>()
            .HasOne(pc=>pc.Campaña)
            .WithMany(c=>c.camp_usuarios)
            .HasForeignKey(pc=>pc.CampañaId);

        }
        public DbSet<Campaña> Campaña { get; set; }
        public DbSet<usuario> usuario{get;set;}
        public DbSet<camp_usuario> camp_usuario{get;set;}

    }
}