using Microsoft.EntityFrameworkCore;
using MinhaApp.Models;

static void AdicionarPedido(ApplicationContext db, Pedido pedido)
{
    db.Pedidos.Add(pedido);
    db.SaveChanges();
    Console.WriteLine("Pedido adicionado com sucesso.");
}

static void ListarPedidos(ApplicationContext db)
{
    var pedidos = db.Pedidos.Include(p => p.Cliente).ToList();
    Console.WriteLine("Listagem de Pedidos:");
    foreach (var p in pedidos)
    {
        Console.WriteLine($"ID: {p.PedidoId}, Descrição: {p.Descricao}, Valor: {p.Valor}, Cliente: {p.Cliente.Nome}");
    }
}

static void AtualizarPedido(ApplicationContext db, Pedido pedido)
{
    db.Pedidos.Update(pedido);
    db.SaveChanges();
    Console.WriteLine("Pedido atualizado com sucesso.");
}

static void ExcluirPedido(ApplicationContext db, int pedidoId)
{
    var pedido = db.Pedidos.Find(pedidoId);
    if (pedido != null)
    {
        db.Pedidos.Remove(pedido);
        db.SaveChanges();
        Console.WriteLine("Pedido excluído com sucesso.");
    }
    else
    {
        Console.WriteLine("Pedido não encontrado.");
    }
}

