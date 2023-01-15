using System;

namespace MatrizDesafio
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dimensoes = Console.ReadLine().Split(' ');
            int[,] mat = new int[int.Parse(dimensoes[0]), int.Parse(dimensoes[1])];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("Position " + i + ", " + j + ".");
                        if (j > 0)
                            Console.WriteLine("Left: " + mat[i, j - 1] + ".");
                        if (i > 0)
                            Console.WriteLine("Up: " + mat[i - 1, j] + ".");
                        if (j < mat.GetLength(1) - 1)
                            Console.WriteLine("Right: " + mat[i, j + 1] + ".");
                        if (i < mat.GetLength(0) - 1)
                            Console.WriteLine("Down: " + mat[i + 1, j] + ".");
                    }
                }
            }
        }
    }
}