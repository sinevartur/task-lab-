using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа.
            //А программа сранивает два введенных числа и выводит на консоль результат сравнения
            //(два числа равны, первое число больше второго или первое число меньше второго).
            Console.WriteLine ("Введите первое число: "); 
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            if (num1 == num2)
            {
                Console.WriteLine("Два числа равны");
            }
            else if (num1 > num2)
            {
                Console.WriteLine("Первое число больше второго");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("Первое число меньше второго");
            }
        }
    }
}



// See https://aka.ms/new-console-template for more information

//task 4
//string s = Console.ReadLine();
//int num = Convert.ToInt32(s);

//switch (num)
//{
//    case 1:
//        Console.WriteLine("понедельник");
//        break;
//    case 2:
//        Console.WriteLine("вторник");
//        break;
//    case 3:
//        Console.WriteLine("среда");
//        break;
//    case 4:
//        Console.WriteLine("четверг");
//        break;
//    case 5:
//        Console.WriteLine("пятница");
//        break;
//    case 6:
//        Console.WriteLine("суббота");
//        break;
//    case 7:
//        Console.WriteLine("воскресенье");
//        break;
//}


//task 5
//string s = Console.ReadLine().ToLower();

// switch(s)
//{
//    case "понедельник":
//        Console.WriteLine("1");
//        break;
//    case "вторник":
//        Console.WriteLine("2");
//        break;
//    case "среда":
//        Console.WriteLine("3");
//        break;
//    case "четверг":
//        Console.WriteLine("4");
//        break;
//    case "пятница":
//        Console.WriteLine("5");
//        break;
//    case "суббота":
//        Console.WriteLine("6");
//        break;
//    case "воскресенье":
//        Console.WriteLine("7");
//        break;
//    default:
//        Console.WriteLine("такого дня недели не существует");
//        break;
//}


//task 9
//string first = Console.ReadLine();
//string second = Console.ReadLine();

//int num1 = Convert.ToInt32(first);
//int num2 = Convert.ToInt32(second);

//int minnum = Math.Min(num1, num2);
//int maxnum = Math.Max(num1, num2);

//for (int i = minnum; i <= maxnum; i++)
//{
//    Console.WriteLine(i);
//}


//task10
//using System.Diagnostics;

//string maxnum = Console.ReadLine();
//string minnum = Console.ReadLine();

//int limit = Convert.ToInt32(maxnum);
//int start = Convert.ToInt32(minnum);

//int total = 0;

//int count = 0;

//while (count <= limit)
//{
//    if (start % 5 == 2 || start % 3 == 1)
//    {
//        total += start;
//        count++;
//    }
//    start++;
//}
//Console.WriteLine(total);


