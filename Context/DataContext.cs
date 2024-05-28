using Microsoft.EntityFrameworkCore;
using Pedido.Model;

namespace Pedido.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base()
        { }
        public DataContext(DbContextOptions options) : base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PedidosDB;ConnectRetryCount=0");
        }
        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<ItemPedido> ItemPedido { get; set; }


    }

}
