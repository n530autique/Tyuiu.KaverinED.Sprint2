using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaverinED.Sprint2.Task7.V8.Lib;
namespace Tyuiu.KaverinED.Sprint2.Task7.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Task7.V8 Выполнил Каверин Е. Д.");
            Console.WriteLine("Введите кординаты x y чтобы определить находиться ли она в закрашенной области");
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ds.CheckDotInShadedArea(x, y) ? "Да, входит" : "Нет, не входит");
            Console.ReadLine();
        }
    }
}
