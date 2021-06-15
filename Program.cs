using System;

namespace PrimeNumberPractice15062021
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int num, count = 0;
            Console.WriteLine("Enter any number");
            num = Convert.ToInt32(Console.ReadLine());

            for(i=1; i<= num; i++)
            {
                if(num % i==0)
                {
                    count = count + 1;

                }

            }
                if(count == 2)
            {
                Console.WriteLine("Number is Prime");

            }
                else
            {
                Console.WriteLine("Number is Not Prime");
                Console.ReadLine();


            }
        }
    }
}
