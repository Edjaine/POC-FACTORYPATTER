
namespace factory_generica
{
    public interface ICartaoCredito
    {
        string cvv { get; set; }
        string Nome { get; set; }
        string Numero { get; set; }
        string Validade { get; set; }
    }
}