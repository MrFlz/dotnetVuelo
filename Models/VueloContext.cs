using Microsoft.EntityFrameworkCore;

namespace dotnetvuelo.Models
{
    public partial class VueloContext : DbContext
    { 
        //public virtual DbSet<RoleModel> RoleM { get; set; }
        //public virtual DbSet<UserModel> UserM { get; set; } 
        public virtual DbSet<VueloModel> VueloM { get; set; }          
        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=vuelos;Username=postgres;Password=1297");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .HasDefaultSchema("public")
            .Entity<VueloModel>()
            .ToTable("vuelo")
            .HasKey(r => r.flyid);

            /*modelBuilder
            .HasDefaultSchema("public")
            .Entity<RoleModel>()
            .ToTable("roles")
            .HasKey(r => r.roleid);

            modelBuilder
            .HasDefaultSchema("public")
            .Entity<UserModel>()
            .ToTable("usuarios")
            .HasKey(r => r.userid);*/
            
        }              
    } 
}