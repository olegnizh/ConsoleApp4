﻿using System;

namespace ConsoleApp431
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] favcolors = new string[3];
            for (int i = 0; i < favcolors.Length; i++)
            {
                Console.WriteLine("Введите любимый цвет номер {0}", i + 1);
                favcolors[i] = Console.ReadLine();
            }

            foreach (var color in favcolors)
            {
                switch (color)
                {
                    case "red":
                        Console.WriteLine("Your color is red!");
                        break;
                    case "green":
                        Console.WriteLine("Your color is green!");
                        break;
                    case "cyan":
                        Console.WriteLine("Your color is cyan!");
                        break;
 
                }

                    
            
            }
                   
            


            }
    }
}
