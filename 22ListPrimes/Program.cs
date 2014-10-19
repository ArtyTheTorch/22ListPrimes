using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22ListPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            printPrimes(num);
            Console.ReadLine();
        }

        private static void printPrimes(int num)
        {
            List<int> primes = getPrimes(num);
            foreach(int i in primes)
            {
                Console.Write(i + ", ");
            }
        }

        private static List<int> getPrimes(int num)
        {
            List<int> primes = new List<int>();

            for (int i = 2; i <= num; i++)
            {
                if (isPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
        }

        private static bool isPrime(int num)
        {
            bool results = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    results = false;
                }
            }
            return results;   
        }
    }
}
