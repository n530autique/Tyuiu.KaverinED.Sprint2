using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaverinED.Sprint2.Task3.V10.Lib;

namespace Tyuiu.KaverinED.Sprint2.Task3.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Write("Введите значение х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ds.Calculate(x));
            Console.ReadLine();
        }
    }
}
