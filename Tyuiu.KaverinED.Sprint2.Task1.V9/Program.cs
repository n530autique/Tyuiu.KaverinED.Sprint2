using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaverinED.Sprint2.Task1.V9.Lib;
namespace Tyuiu.KaverinED.Sprint2.Task1.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 15;
            int b = 335;
            int c = 174;
            int d = 478;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            Console.Title = "Спринт #2 | Выполнил: Каверин Е. Д. | ИИПБ-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант 9                                                               *");
            Console.WriteLine("* Выполнил: Каверин Егор Дмитриевич | ИИПБ-23-3                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* ожно чередовать, но использовать один раз в выражении) и логических     *");
            Console.WriteLine("* операций(|, &, ||, &&, !, ^, последовательность операций не должна      *");
            Console.WriteLine("* нарушаться), а также арифметических выражений, которая  вернет          *");
            Console.WriteLine("* логическую последовательность: False, False, True, False, True, False   *");
            Console.WriteLine("* False), при a = 15, b = 335, c = 174, d = 478                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; i++) Console.WriteLine(res[i]);
            Console.ReadKey();
        }
    }
}
