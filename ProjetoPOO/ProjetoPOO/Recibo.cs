using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO
{
    internal class Recibo
    {
        public static readonly byte CREDITO = 1;
        public static readonly byte DEBITO = 2;
        public static readonly byte DINHEIRO = 3;
        
        public Dictionary<Produto, double> itens = new Dictionary<Produto, double>();
        public DateTime dataCompra;
        public byte metodoPagamento;
        public Loja? loja;
        public Cliente? cliente;

        public void AdicionaItem(Produto produto, double quantidades)
        {
            if (produto.estoque > quantidades)
            {
                itens.Add(produto, quantidades);
                produto.AlteraQuant(-quantidades);
            } else
            {
                Console.WriteLine("Produto não tem estoque o suficiente.");
            }
        }
        public void RemoveItem(Produto produto, double quantidades)
        {
            if (itens.ContainsKey(produto) && itens[produto] >=quantidades)
            {
                if (itens[produto] - quantidades > 0)
                {
                    itens[produto] -= quantidades;
                }
                else
                {
                    itens.Remove(produto);
                }
                produto.AlteraQuant(quantidades);
            } else
            {
                Console.WriteLine("Você está tentando remover um produto não listado.");
            }
        }
        public bool TemDesconto()
        {
            if (cliente.temCartaoLoja == true)
            {
                return true;
            }
            else return false;
        }
        public void ImprimeResultado()
        {
            double total=0;
            Console.WriteLine("Produto            Preço   Quant.   Preço Total");
            foreach (KeyValuePair<Produto, double> entry in itens)
            {
                total += entry.Key.preco * entry.Value;
                Console.WriteLine($"{entry.Key.descricao}    {entry.Key.preco}    {entry.Value}      {entry.Key.preco * entry.Value}");
            }
            if (TemDesconto())
            {
                total *= (0.9);
            }
            dataCompra = DateTime.Now;
            Console.WriteLine($"O total foi: R${total.ToString("F")}");
            Console.WriteLine($"Compra efetuada em: {dataCompra.ToString("dd/MM/yyyy hh:mm")}");
        }
    }
}
