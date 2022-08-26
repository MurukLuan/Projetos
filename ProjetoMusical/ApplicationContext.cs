using Microsoft.EntityFrameworkCore;

namespace ProjetoMusical
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Produto>().HasKey(t => t.Id);
            modelBuilder.Entity<Pedido>().HasKey(t => t.Id);
            modelBuilder.Entity<ItemPedido>().HasKey(t => t.Id);
            modelBuilder.Entity<Cadastro>().HasKey(t => t.Id);
        }
    }
}
