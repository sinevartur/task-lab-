namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int A = 1;
            int[] a = { 1, 2, 3, 4 };
            double[] b = { 1.1, 2.2, 3.3, 4.4 };
            Random randomizer = new Random();
            int[,] M = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 10 }
            };
            int answer1 = program.Task1(M);
            Console.WriteLine(answer1);

            int answer2 = program.Task2(M);
            Console.WriteLine(answer2);

            int answer3 = program.Task3(M);
            Console.WriteLine(answer3);

            int[,] answer4 = program.Task4(M);
            Console.WriteLine(answer4);

            int[,] answer5 = program.Task5(M, A);
            Console.WriteLine(answer5);

            int[,] answer6 = program.Task6(M);
            Console.WriteLine(answer6);
        }

        public int Task1(int[,] matrix)
        {
            int k = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 3 == 0) k++;
                }
            }
            return k;
        }

        public int Task2(int[,] matrix)
        {
            int k = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int count = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 3 == 0) count++;
                }
                if (count == 0) k++;
            }
            return k;
        }

        public int Task3(int[,] matrix)
        {
            int k = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int count = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] % 3 == 0) count++;
                }
                if (count == 0) k++;
            }
            return k;
        }

        public int[,] Task4(int[,] matrix)
        {
            int k = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int count = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] % 3 == 0) count++;
                }
                if (count == 0) k++;
            }

            int[,] answer = new int[matrix.GetLength(0), k];
            int index = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int count = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] % 3 == 0) count++;
                }
                if (count == 0)
                {
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        answer[i, index] = matrix[i, j];
                        index++;
                    }
                }
            }
            
            return answer;
        }

        public int[,] Task5(int[,] matrix, int a)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            if (a < 0 || a >= n) return null;

            int[,] answer = new int[n + 1, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i < a)
                    {
                        answer[i, j] = matrix[i, j];
                    }
                    if (i >= a)
                    {
                        answer[i + 1, j] = matrix[i, j];
                    }
                }
            }
            
            for (int j = 0; j < m; j++)
            {
                answer[a, j] = -1;
            }

            return answer;
            
        }

        public int[,] Task6(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            if (n != m) return null;


            
            return null;
        }

        public static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Print(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Print(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
            Console.WriteLine();
        }

        public static void Print<T>(T[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

//вывод матрицы 
//int[,] answer1 = program.Task1(M);
//Console.WriteLine(answer1);
//for (int i = 0; i < answer1.GetLength(0); i++) 
//{
//    for (int j = 0; j < answer1.GetLength(1); j++) 
//    {
//        Console.Write($"{answer1[i, j],5}"); 
//    }
//    Console.WriteLine(); 
//}
