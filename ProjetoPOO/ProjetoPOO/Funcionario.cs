using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO
{
    internal class Funcionario : Pessoa {

        public string funcao;
        public Gerente? gerente;
        bool estaDeFerias = false;
        public bool EstaDeFerias
        {
            get { return estaDeFerias; }

            set { estaDeFerias = value; }
        }


    }
}
