namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int[,] M = new int[,]
            {
                { 1, 2, 3, 80, 33 },
                { 4, 5, 6, 90, 20 },
                { 7, 8, 10, 88, 19 },
                { 99, 11, 77, 22, 17 },
                { 12, 13, 14, 15, 16 }
            };

            int[,] answer1 = program.Task1(M);
            Console.WriteLine(answer1);
            for (int i = 0; i < answer1.GetLength(0); i++)
            {
                for (int j = 0; j < answer1.GetLength(1); j++)
                {
                    Console.Write($"{answer1[i, j],5}");
                }
                Console.WriteLine();
            }

            int[,] M2 = new int[,]
            {
                { 1, 2, 3, 80 },
                { 4, 5, 6, 90 },
                { 7, 8, 10, 88 },
                { 99, 11, 77, 22 }
            };

            int[,] answer2 = program.Task2(M2);
            Console.WriteLine(answer2);
            for (int i = 0; i < answer2.GetLength(0); i++)
            {
                for (int j = 0; j < answer2.GetLength(1); j++)
                {
                    Console.Write($"{answer2[i, j],5}");
                }
                Console.WriteLine();
            }
        }

        public int[,] Task1(int[,] matrix)
        {

            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int[,] answer = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    answer[n - 1 - i, m - 1 - j] = matrix[i, j];
                }
            }
            return answer;
        }

        public int[,] Task2(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int[,] answer = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < m; j++)
                {
                    if ((i + j) < (n - 1))
                    {
                        (matrix[i, j], matrix[n - 1 - i, m - 1 - j]) = (matrix[n - 1 - i, m - 1 - j], matrix[i, j]);
                    }
                }
            }
            return answer;
        }
    }
}

