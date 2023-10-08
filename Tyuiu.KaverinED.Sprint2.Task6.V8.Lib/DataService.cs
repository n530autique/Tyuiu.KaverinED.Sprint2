using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KaverinED.Sprint2.Task6.V8.Lib
{
    public class DataService : ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            /// <summary>
            /// m - месяц
            /// n - день
            /// </summary>
            Dictionary<int, int> lastDayOfMonth = new Dictionary<int, int>()
            {
                {1, 31},
                {2, 28},
                {3, 31},
                {4, 30},
                {5, 31},
                {6, 30},
                {7, 31},
                {8, 31},
                {9, 30},
                {10, 31},
                {11, 30},
                {12, 31}
            };
            Func<int, string> addZero = x => (x) < 10 ? $"0{x}" : Convert.ToString(x);
            return n == 1 ? $"{lastDayOfMonth[m - 1]}.{addZero(m- 1)}" : $"{addZero(n - 1)}.{addZero(m)}";
        }

    }
}
