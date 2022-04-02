using Newtonsoft.Json;

namespace BFF.Model
{
    public class Cliente
    {
        [JsonProperty("idcliente")]
        public int IdCliente { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }
    }
}
