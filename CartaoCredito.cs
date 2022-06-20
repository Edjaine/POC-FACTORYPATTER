using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_generica
{
    public abstract class CartaoCredito : ICartaoCredito
    {
        public CartaoCredito(string nome, string numero, string cvv, string validade)
        {
            Nome = nome;
            Numero = numero;
            this.cvv = cvv;
            Validade = validade;
        }

        public string Nome { get; set; }
        public string Numero { get; set; }
        public string cvv { get; set; }
        public string Validade { get; set; }
    }
}
