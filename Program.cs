using factory_generica;

var visa = FactoryCartao.Construir<Visa>("Edjaine");
var master = FactoryCartao.Construir<MasterCard>("Bruno");

Console.WriteLine($"A Razão Social da Visa é {visa?.RazaoSocial}");
Console.WriteLine($"A Razão Social da MasterCard é {master?.RazaoSocial}");