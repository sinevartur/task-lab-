using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace sinartc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = int.Parse(Console.ReadLine());
            //double d = double.Parse
            while(true)
            {
                // task 1
                //    int a = int.Parse(Console.ReadLine());
                //    if ((a % 3 == 0) && (a % 7 == 0))
                //    { Console.WriteLine($"число {a} делится на 3 и на 7"); }
                //    else { Console.WriteLine("не делится"); }\

                // task 2
                //int a = int.Parse(Console.ReadLine());
                //int b = int.Parse(Console.ReadLine());
                //if (a == b) { Console.WriteLine("числа равны"); }
                //else if (a > b) { Console.WriteLine("первое число больше "); }
                //else { Console.WriteLine("второе число больше"); } 

                // task 3
                //int sum = 0;
                //int a = 0;
                //do
                //{
                //    a = int.Parse(Console.ReadLine());
                //    sum += a;
                //    Console.WriteLine(sum);
                //} while (a != 0);

                // task 6
                int summ = 0;
                n = 1
                int a = int.Parse(Console.ReadLine());
                for (int i = 1; i <= a; i += 2)
                {
                    if (i % 2 != 0)
                    {
                        summ += i;
                        Console.WriteLine(i);
                    }
                }
                while (n <= a)
                {
                    if (n % 2 != 0) 
                    {
                        summ += n;
                        Console.WriteLime(n)
                    }
                    n += 2
                }
            }
        }
    }
}

// Напишите программу, в которой вычисляется сумма нечетных чисел. Для проверки результата воспользуйтесь тем,
// что 2 + 4 + 6 + ". + 2п = п(п + 1). Предложите версии программы, использующие разные операторы цикла. 
