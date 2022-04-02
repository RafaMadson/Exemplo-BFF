using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace MSCliente.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private static readonly List<Cliente> clientes = new List<Cliente>
        {
            new Cliente(){ IdCliente = 1, Idade = 29,  Nome = "Rafael", SobreNome = "Muniz"},
            new Cliente(){ IdCliente = 2, Idade = 28,  Nome = "Gabriela", SobreNome = "Avila"},
            new Cliente(){ IdCliente = 3, Idade = 3,  Nome = "Theo", SobreNome = "Muniz"},
            new Cliente(){ IdCliente = 4, Idade = 9,  Nome = "Arthur", SobreNome = "Gomes"},
        };

        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Cliente Get(int id)
        {
            return clientes.FirstOrDefault(x => x.IdCliente == id);
        }
    }
}
