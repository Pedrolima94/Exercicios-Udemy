using System.Globalization;

namespace CalcularNota
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno al = new Aluno();

            Console.Write("Nome do aluno: ");
            al.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            al.Nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            al.Nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            al.Nota3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Nota final = "
                + al.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (al.Aprovado())
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram "
                    + al.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                    + " Pontos");
            }
            


        }
    }
}