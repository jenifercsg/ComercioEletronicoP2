using Microsoft.AspNetCore.Mvc;
using Pedido.Model;
using Pedido.Context;
using Microsoft.AspNetCore.Mvc.ModelBinding;


namespace PedidoController
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public PedidoController()
        {
            _dataContext = new DataContext();
        }

        [HttpGet]  
        public ActionResult<List<Pedidos>> Get()
        {
            var pedidos = _dataContext.Pedidos.ToList();
            return pedidos;
        }

        [HttpGet("{id}")]
        public ActionResult<Pedidos> Get(int id)
        {
            var pedidos = _dataContext.Pedidos.FirstOrDefault(x => x.PedidoId == id);
            
            if (pedidos == null)
            {
                return BadRequest("Id de pedido não existente");
            }

            return pedidos;
        }


        [HttpPost]
        public ActionResult<Pedidos> Post([FromBody] Pedidos pedidos)
        {
            if (ModelState.IsValid)
            {
                _dataContext.Pedidos.Add(pedidos);
                _dataContext.SaveChanges();

                return pedidos;
            }

            return BadRequest(ModelState);


        }


    }
}
