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
        public string descricao;
        public double preco;
        public double estoque;
        public int unidadeDeMedida;
        public Loja loja;

        public void AlteraQuant(double quant)
        {
            estoque += quant;
        }
        public void AlteraPreco (double novoPreco)
        {
            preco = novoPreco;
        }
    }
}
