using System;

namespace ConsoleApp415
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 1;
            int B = 2;
            double X = 1.3;
            double Y = 1.5;

            bool C = (A < B) | (X > Y);
            Console.WriteLine(C);


        }
    }
}
