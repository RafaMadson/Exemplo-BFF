using System;

namespace MSPedido
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public decimal SubValor { get; set; }
        public decimal Desconto { get; set; }
        public decimal Frete { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCompra { get; set; }
        public string Cep { get; set; }
    }
}
