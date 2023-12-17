using System;

namespace ConsoleApp435
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine("Ваше имя по буквам");            
            foreach (var ch in name)
            {
                Console.Write(ch + " ");
            }
            Console.Write("Последняя буква {0}", name[name.Length - 1]);
        }


    }
}
