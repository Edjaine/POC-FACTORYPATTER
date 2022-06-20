using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_generica
{
    public class Visa : CartaoCredito, ICartaoCredito
    {
        public Visa(string nome, string numero, string cvv, string validade) : base(nome, numero, cvv, validade)
        {
        }

        public string RazaoSocial { get { return "Visa do Brasil"; } }
    }
}
