using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaverinED.Sprint2.Task6.V8.Lib;
namespace Tyuiu.KaverinED.Sprint2.Task6.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine(" Task6.V8 выполнил Каверин Е. Д.");
            Console.WriteLine("Дата некоторого дня характеризуется двумя натуральными \n числами: m (порядковый номер месяца) и n (число). По заданным n и m определить дату предыдущего дня \n (принять, что n и m не характеризуют 1 января).");
            Console.Write("Введите значение m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string res = Convert.ToString(ds.FindDateOfPreviousDay(m, n));
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
