using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO
{
    public class Produto
    {
        public long codigoBarras;
        public string? descricao;
        public double preco;
        public double estoque;
        public string? unidadeDeMedida;
        public Loja? loja;

        public void AlteraQuant(double quant)
        {
            estoque += quant;
        }
        public void AlteraPreco (double novoPreco)
        {
            preco = novoPreco;
        }

        public void ImprimeDados()
        {
            Console.WriteLine("Descrição: " + this.descricao);
            Console.WriteLine("Preço: R$" + this.preco);
            Console.WriteLine("Unidade de Medida: " + this.unidadeDeMedida);
            Console.WriteLine("Quantidade em estoque: " + this.estoque);
        }
    }
}
