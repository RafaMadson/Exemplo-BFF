using BFF.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Refit;
using System.Threading.Tasks;
using BFF.Model;

namespace BFF.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppController : ControllerBase
    {
        private readonly ILogger<AppController> _logger;
        private readonly IClienteRefit _clientCliente;
        private readonly IPedidoRefit _clientPedido;
        private readonly IRegiaoRefit _clientRegiao;

        public AppController(ILogger<AppController> logger)
        {
            _logger = logger;
            _clientCliente = RestService.For<IClienteRefit>("http://localhost:49584/");
            _clientPedido = RestService.For<IPedidoRefit>("http://localhost:49593/");
            _clientRegiao = RestService.For<IRegiaoRefit>("https://viacep.com.br/");
        }

        [HttpGet("GetCustomer")]
        public Task<Cliente> GetCustomer(int id)
        {
            return _clientCliente.SelecionarAsync(id);
        }

        /// Selecionar um pedido pelo id
        [HttpGet("GetOrder")]
        public Task<Pedido> GetOrder(int id)
        {
            var pedido = _clientPedido.SelecionarAsync(id).GetAwaiter().GetResult();

            var regiao = _clientRegiao.SelecionarPorCepAsync(pedido.Cep).GetAwaiter().GetResult();

            pedido.Cidade = regiao.Localidade;

            return Task.FromResult(pedido);
        }
    }
}
