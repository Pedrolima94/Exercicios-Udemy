using System.Threading.Channels;
using System.Globalization;

namespace FuncionarioDados
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Funcionarios f1, f2;
            
            f1 = new Funcionarios();
            f2 = new Funcionarios();

            Console.WriteLine("Dados do Primeiro funcionario: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();

            Console.Write("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do Segundo funcionario");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();

            Console.Write("Salario: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double media = (f1.Salario + f2.Salario) / 2.0;

            Console.Write("Salario Medio = " + media.ToString("F2", CultureInfo.InvariantCulture));

          
        }
    }
}