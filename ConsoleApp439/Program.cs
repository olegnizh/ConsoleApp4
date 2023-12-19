using System;

namespace ConsoleApp439
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }


        }
    }
}
