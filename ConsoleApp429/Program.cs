using System;

namespace ConsoleApp429
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // 1
            Console.WriteLine("Цикл с предусловием");
            int k = 0;
            while (k < 3)
            {
                Console.WriteLine(k);
                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                switch (Console.ReadLine())
                {
                    case "red":
                        k++;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is red!");
                        break;
                    case "green":
                        k++;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is green!");
                        break;
                    case "cyan":
                        k++;
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        break;
                }
            }
            
            // 2
            Console.WriteLine("Цикл с постусловием");
            int x = 0;
            do
            {
                if (x == 3)
                    break;

                Console.WriteLine(x);
                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                switch (Console.ReadLine())
                {
                    case "red":
                        x++;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is red!");
                        break;
                    case "green":
                        x++;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is green!");
                        break;
                    case "cyan":
                        x++;
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        break;
                }
            } while (true);
            
            // 3
            Console.WriteLine("Цикл for");
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is red!");
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        break;
                }
            }


        }
    }
}
