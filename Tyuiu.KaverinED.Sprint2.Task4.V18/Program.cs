using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaverinED.Sprint2.Task4.V18.Lib;
namespace Tyuiu.KaverinED.Sprint2.Task4.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Результат: ");
            Console.Write(ds.Calculate(x, y));
            Console.ReadLine();
        }
    }
}
