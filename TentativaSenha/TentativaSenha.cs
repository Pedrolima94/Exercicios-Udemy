namespace TentativaSenha
{
    internal class TentativaSenha
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Coloque a senha");
            double senha = double.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine();
                Console.WriteLine("Acesso negado, tente outra senha");
                senha = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Senha correta!");
        }
    }
}
