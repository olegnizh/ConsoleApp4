using System;

namespace ConsoleApp4213
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Цикл while");
            int k = 0;
            while (k < 0)
            {
                Console.WriteLine(k);
                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is red!");
                        break;
                }
                k++;
            }

            Console.WriteLine("Цикл do");
            int t = 0;
            do
            {
                Console.WriteLine(t);
                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is red!");
                        break;
                }
                t++;
            } while (t < -1);


        }
    }
}
