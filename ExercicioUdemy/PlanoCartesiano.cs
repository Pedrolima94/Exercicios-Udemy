﻿namespace ExercicioUdemy
{
    internal class PlanoCartesiano
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Coloque a coordenada");

            string[] coordenadas = Console.ReadLine().Split(' ');

            int x = int.Parse(coordenadas[0]);
            int y = int.Parse(coordenadas[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }

                Console.WriteLine();

                coordenadas = Console.ReadLine().Split(' ');

                x = int.Parse(coordenadas[0]);
                y = int.Parse(coordenadas[1]);
            }
        }
    }
}
