using System;

namespace CShildt
{
    class Program
    {
        static void Main(string[] args)
        {/*
            double radius, area;

            radius = 10;
            area = radius * radius * 3.1416;
            Console.WriteLine("Площадь равна " + area);
            

            int a, b, c;
            a = 2;
            b = 3;

            if(a < b)
                Console.WriteLine("a меньше b");

            if(a == b)
                Console.WriteLine("этого никто не увидит");

            Console.WriteLine();

            c = a - b;
            Console.WriteLine("c содержит -1");
            if(c >= 0)
                Console.WriteLine("значение с неотрицательно");
            if(c < 0)
                Console.WriteLine("значение с отрицательно");
            Console.WriteLine();

            c = b - a;
            Console.WriteLine("c содержит 1");
            if (c >= 0)
                Console.WriteLine("значение с неотрицательно");
            if (c < 0)
                Console.WriteLine("значение с отрицательно");
            */

            int sum = 0;
            int prod = 1;

            for(int i = 1; i <= 10; i++)
            {
                sum = sum + i;
                prod = prod * i;
            }

            Console.WriteLine("Сумма равна " + sum);
            Console.WriteLine("Произведение равно " + prod);
        }
    }
}
