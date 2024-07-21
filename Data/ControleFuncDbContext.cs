using ControleFuncionario.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace ControleFuncionario.Data
{
    public class ControleFuncDbContext : DbContext
    {
        //public ControleFuncDbContext(DbContextOptions<ControleFuncDbContext> options) : base(options)
        //{

        //}
        
        // Tabelas
        DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("FuncionarioDB");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.Property(prop => prop.Id);
                entity.HasKey(prop => prop.Id);                
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
