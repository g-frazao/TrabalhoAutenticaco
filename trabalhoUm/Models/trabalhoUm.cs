using Microsoft.EntityFrameworkCore;

namespace MinhaApp.Models
{
    public class Cliente
    {
        internal object Pedidos;

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }

    public class Pedido
    {
        public int PedidoId { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }

    public class ApplicationContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

    }
}
