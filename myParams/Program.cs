using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int total;

            Console.Write("How many random numbers do you want to generate? \nEnter: ");
            int size = int.Parse(Console.ReadLine());
            int[] randomNumbers = new int[size];
            Console.Clear();

            Console.WriteLine("----Random Numbers----");

            for (int i = 0; i < size; i++)
            {
                randomNumbers[i] = ran.Next(100);
                Console.WriteLine(randomNumbers[i]);
            }

            Console.WriteLine();
            Console.WriteLine("All of the random numbers have been generated!");
            Console.Write("Would you like to Add or Multiply all of the numbers? \n(A - add or M - multiply)\nEnter: ");
            char desicion = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (desicion) 
            {
                case 'A':
                    total = Add(randomNumbers);
                    Console.WriteLine("Addition");
                    Display(total);
                    break;
                case 'M':
                    total = Multiply(randomNumbers);
                    Console.WriteLine("Multiplication");
                    Display(total);
                    break;
                default: 
                    Console.WriteLine("Please enter an option!");
                    break;
            }


        }

        static void Display(int number)
        {
            Console.WriteLine($"The total is: {number}");
        }

        static int Add(params int[] randomNumbers)
        {
            int total = 0;
            for (int i = 0; i < randomNumbers.Length; i++) 
            {
                total += randomNumbers[i];
            }
            return total;
        }

        static int Multiply(params int[] randomNumbers)
        {
            int total = 1;
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                total *= randomNumbers[i];
            }
            return total;
        }
    }
}
