using System;

namespace Day7_Assignments
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 7 Assignments");
            FindPrimeFactors();


        }
            public static void FindPrimeFactors()
            {
                Console.WriteLine("Finding prime factors\n");
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine("Prime factors of " + num);
                for (int i = 2; i * i <= num; i++)
                {
                    while (num % i == 0)
                    {
                        num /= i;
                        Console.WriteLine(i);
                    }
                }

                if (num >= 2)
                {
                    Console.WriteLine(num);
                }

            }



        }
    }
