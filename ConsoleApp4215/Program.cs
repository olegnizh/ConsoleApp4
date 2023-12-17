using System;

namespace ConsoleApp4215
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (true)
            {
                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                Console.WriteLine(n);
                var text = Console.ReadLine();
                if (text == "stop")
                {
                    Console.WriteLine("Цикл остановлен");
                    break;
                }

                switch (text)
                {
                    case "red":
                        n++;
                        Console.WriteLine("Вы иыбрали номером {0} цвет {1}", n, text);
                        break;
                    case "green":
                        n++;
                        Console.WriteLine("Вы иыбрали номером {0} цвет {1}", n, text);
                        break;
                    case "cyan":
                        n++;
                        Console.WriteLine("Вы иыбрали номером {0} цвет {1}", n, text);
                        break;
                    default:
                        //Console.WriteLine("Вы не выбрали ничего");
                        continue;
                       
                }
            }


        }
    }
}
