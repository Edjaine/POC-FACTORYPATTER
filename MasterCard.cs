using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_generica
{
    public class MasterCard: CartaoCredito, ICartaoCredito
    {
        public MasterCard(string nome, string numero, string cvv, string validade) : base(nome, numero, cvv, validade)
        {
        }

        public string RazaoSocial { get { return "MasterCard do Brasil"; } }
    }
}
