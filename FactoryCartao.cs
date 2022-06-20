using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace factory_generica
{
    public static class FactoryCartao
    {
        private static Random rnd = new Random();
        public static T? Construir<T>(string nome) where T : ICartaoCredito
        {
           var partNumeroCartao = rnd.Next(999999).ToString("000000");
           var numeroCartao = $"545467{partNumeroCartao}9999";
           var cvv = rnd.Next(999).ToString("000");
           var validade = DateTime.Now.AddYears(3).ToString("mm/yyyy");

           var listArg = new List<Object>() { nome, numeroCartao, cvv, validade };

           return (T) Activator.CreateInstance(typeof(T)
                       , listArg.ToArray());
            
        }
    }
}
