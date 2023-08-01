using DesignPatterns;





Orcamento orcamento = new Orcamento(900);
CalculadorDeImposto calculador = new CalculadorDeImposto();

double valorImpostoICMS = calculador.CalculadorImposto(orcamento, new ICMS());
Console.WriteLine("Valor do imposto ICMS a ser pago: R$ " + valorImpostoICMS.ToString("F2"));