using BFF.Model;
using Refit;
using System.Threading.Tasks;

namespace BFF.Interface
{
    public interface IRegiaoRefit
    {

        [Get("/ws/{cep}/json")]
        Task<Regiao> SelecionarPorCepAsync(string cep);

    }
}
