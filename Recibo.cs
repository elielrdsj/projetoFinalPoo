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
        
        public Dictionary<Produto, double> itens;
        public DateTime dataCompra;
        public byte metodoPagamento;
        public Loja loja;
        public Cliente cliente;

        public void AdicionaItem(Produto produto, double quantidades)
        {
            itens.Add(produto, quantidades);
        }
        public void RemoveItem(Produto produto, double quantidades)
        {
            if (itens.ContainsKey(produto) && itens[produto] >=quantidades)
            {
                itens.Remove(produto);
            } else
            {
                Console.WriteLine("Você está tentando remover um produto não listado.");
            }
        }
        public bool TemDesconto(Cliente cliente)
        {
            if (cliente.temCartaoloja == true)
            {
                return true;
            }
            else return false;
        }
        void ImprimeResultado()
        {
            double total=0;
            Console.WriteLine("Produto       Preço      Quantidade      Preço Total");
            foreach (KeyValuePair<Produto, double> entry in itens)
            {
                total += entry.Key.preco * entry.Value;
                Console.WriteLine($"{entry.Key}    {entry.Key.preco}    {entry.Value}      {entry.Key.preco * entry.Value}");
            }
            if (TemDesconto(cliente))
            {
                total *= (0.9);
            }
            Console.WriteLine($"O total foi: R${total}");
        }
    }
}
