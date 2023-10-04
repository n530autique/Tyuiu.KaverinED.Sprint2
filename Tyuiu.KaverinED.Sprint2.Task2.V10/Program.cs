using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaverinED.Sprint2.Task2.V10.Lib;
namespace Tyuiu.KaverinED.Sprint2.Task2.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            DataService.PrintArea(DataService.Area.array);
            Console.Write("Введите значение x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            x -= 1;
            y -= 1;
            Console.Clear();
            int[,] newArr = DataService.Area.array;
            result = DataService.Area.array[x, y];
            newArr[x, y] = 2;
            DataService.PrintArea(DataService.Area.array);
            if (result == 1)
            {
                Console.WriteLine($"Точка ({x}, {y}) находится в закрашенной области");
            }
            else
            {
                Console.WriteLine($"Точка ({x}, {y}) не находится в закрашенной области");
            }
            Console.ReadLine();
        }
    }
}
