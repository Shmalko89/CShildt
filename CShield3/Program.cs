using System;

namespace CShield4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Применение оператора %
            /*
            int iresult, irem;
            double dresult, drem;

            iresult = 10 / 3;
            irem = 10 % 3;

            dresult = 10.0 / 3.0;
            drem = 10.0 % 3.0;

            Console.WriteLine("Результат и остаток от деления 10 / 3: " +
                iresult + " " + irem);

            Console.WriteLine("Результат и остаток от деления 10 / 3: " +
                dresult + " " + drem);

            //Инкремент декримент
            
            int x = 10;
            int y = ++x;
            Console.WriteLine(y);

            y = x++;

            Console.WriteLine(y);

            //еще пример постфиксный

            int x = 1, y = 0;

            Console.WriteLine("Ряд чисел, полученных " + "с помощью оператора y = y + x++;");

            for (int i = 0; i < 10; i++)
            {
                y = y + x++;
                Console.WriteLine(y + " ");
            }
            */
            //префиксный
            int x = 1, y = 0;

            Console.WriteLine("Ряд чисел, полученных " + "с помощью оператора y = y + x++;");

            for (int i = 0; i < 10; i++)
            {
                y = y + ++x;
                Console.WriteLine(y + " ");
            }
        }
    }
}
