using BFF.Model;
using Refit;
using System.Threading.Tasks;

namespace BFF.Interface
{
    public interface IClienteRefit
    {
        [Get("/cliente?id={idCliente}")]
        Task<Cliente> SelecionarAsync(int idCliente);
    }
}
