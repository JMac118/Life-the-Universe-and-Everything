using System;

namespace Life__the_Universe__and_Everything
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            while(input != 42)
            {
                input = int.Parse(Console.ReadLine());

                if(input != 42)
                {
                    Console.WriteLine(input);
                }
            }
        }
    }
}
