using System.Globalization;

namespace PrecoComputador
{
    internal class PrecoComputador
    {
        private static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"Computador, cujo preço é $ {preco1}");
            Console.WriteLine($"Mesa de escritório, cujo preço é $ {preco2}");

            Console.WriteLine();

            Console.WriteLine($"Registro:{idade} anos de idade, código{codigo} e genero{genero}");
            Console.WriteLine();

            Console.WriteLine($"Medida com oito casas decimais:{medida:F8} ");
            Console.WriteLine($"Arredondado(três casas decimais):{medida:F3} ");
            Console.WriteLine("Separador decimal : " + medida.ToString("F3", CultureInfo.InvariantCulture));


            Console.Clear();

            Console.WriteLine(" Digite o  primeiro numero que deseja SOMAR");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero que deseja SOMAR");
            float n2 = float.Parse(Console.ReadLine());

            float resultado = n1 + n2;

            Console.WriteLine($"O resultado da soma é:{resultado}");
            Console.ReadKey();
        }
    }
}
