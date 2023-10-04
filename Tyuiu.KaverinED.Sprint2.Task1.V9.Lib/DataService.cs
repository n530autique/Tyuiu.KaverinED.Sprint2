using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KaverinED.Sprint2.Task1.V9.Lib
{
    public class DataService : ISprint2Task1V9
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            //a = 15, b = 335, c = 174, d = 478
            //False, False, True, False, True, False
            //|, &, ||, &&, !, ^
            bool[] res = { 
                (a > b) | (c >= d),
                (a<b) & (c>d),
                (a < b) || (c == d),
                (a != b) && (c == d),
                !((a == b) != (c == d)),
                (a == b) ^ (c == d)
            };
            return res;
        }
    }
}
