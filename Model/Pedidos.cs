using System.ComponentModel.DataAnnotations;

namespace Pedido.Model
{
    public class Pedidos
    {
        public Pedidos(int clienteId, DateTime dataPedido)
        {
            ClienteId = clienteId;
            DataPedido = dataPedido;
        }

        [Key]
        public int PedidoId { get; set; }
        public int ClienteId { get; set; }
        public DateTime DataPedido { get; set; }
        public List<ItemPedido> Item {  get; set; }

    
    }
}
