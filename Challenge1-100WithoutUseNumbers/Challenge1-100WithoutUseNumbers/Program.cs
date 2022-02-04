using System;

namespace Challenge1_100WithoutUseNumbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //First Way

            Console.WriteLine("First Way");

            var one = ".";
            var ten = "..........";

            for (int i = one.Length; i <= (ten.Length * ten.Length); i++)
                Console.WriteLine(i);

            //Second Way

            Console.WriteLine("\nSecond Way");

            var x = "";
            var z = x.Length;
            var first = true;

            z++;

            if (first)
            {
                x = z.ToString() + x.Length.ToString() + x.Length.ToString();
                first = false;
                while (z <= int.Parse(x))
                {
                    Console.WriteLine(z);
                    z++;
                }
            }
        }
    }
}