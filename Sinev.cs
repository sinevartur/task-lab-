using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            a = 1;
            Console.WriteLine($"{a,4}");
            Console.WriteLine();

            int[] b = new int[5];
            int num_b = 1;
            for (int i = 0; i < b.Length; i++)
            {
                if(i % 4 == 0)
                {
                    b[i] = num_b;
                    num_b++;
                }
            }

            for (int i = 0; i < b.Length; i++)
            {
                Console.Write($"{b[i],4}");
            }
            Console.WriteLine();
            Console.WriteLine();

            int[,] c = new int[4, 5];
            int num_c = 1;
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    if ((i == 0) || (i == 1 && (j % 4 == 0)) || (i == 2 && (j % 4 == 0)) || (i == 3))
                    {
                        c[i, j] = num_c;
                        num_c++;
                    }
                }
            }

            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write($"{c[i, j],4}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //int[,,] d = new int[3, 4, 5];
            //int num_d = 1;
            //for (int i = 0; i < d.GetLength(0); i++)
            //{
            //    for (int j = 0; i < d.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < d.GetLength(2); k++)
            //        {

            //        }
            //    }
            //}

            Random randomizer = new Random();
            

            int[,] matrix = new int[3, 5];
            int[,] trans = new int[5, 3];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = randomizer.Next(10);
                    trans[j, i] = matrix[i, j];
                }
            }
            matrix = trans;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }
    }
}
