using System.Globalization;

namespace CotacaoDolar
{
   class Program
    {
        static void Main(string[] args)
        {
            Dolar dolar = new Dolar();

            Console.Write("Qual a cotação do Dolar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = Dolar.DolarParaReal(quantia, cotacao);
            
            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}