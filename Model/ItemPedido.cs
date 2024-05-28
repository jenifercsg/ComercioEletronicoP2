using System.ComponentModel.DataAnnotations;

namespace Pedido.Model
{
    public class ItemPedido
    {
        public ItemPedido(int pedidoId,int quantidade , double preco) 
        {
            PedidoId = pedidoId;
            Quantidade = quantidade;
            Preco = preco;
        }

        [Key]
        public int ItemPedidoId { get; set; }
        public int PedidoId { get; set; }
        public Pedidos Pedido { get; set; }
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
    }

}
