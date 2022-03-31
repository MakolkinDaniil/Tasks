using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalcLib
{
    public class MyCalc
    {
        public int Nod(int a, int b, int c)
        {
            while (a != b) // Ищем максимальное число для первых двух чисел и отнимаем меньшее от большего до тех пор, пока они не сравняются
            {
                if (a > b) { a -= b; }
                else { b -= a; }
            }

            while (a != c)
            {
                if (a > c) { a -= c; } // То же самое, но для первого и последнего числа
                else { c -= a; }
            }
            return a;
        }
    }
}
