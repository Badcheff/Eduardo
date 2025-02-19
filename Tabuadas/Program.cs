using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual tabuada queres saber?");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i+1}*" + num + "=" + (i+1) * num);
            }
        }
    }
}
