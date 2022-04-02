using BFF.Model;
using Refit;
using System.Threading.Tasks;

namespace BFF.Interface
{
    public interface IPedidoRefit
    {
        [Get("/pedido?id={idPedido}")]
        Task<Pedido> SelecionarAsync(int idPedido);
    }
}
