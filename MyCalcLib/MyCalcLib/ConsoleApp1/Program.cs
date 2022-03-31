using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("число 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("число 2: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("число 3: ");
            int c = int.Parse(Console.ReadLine());
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
            Console.Write("НОД: "+ a);
        }
    }
}
