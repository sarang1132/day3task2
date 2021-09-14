using System;

namespace day3task2
{
    class Calculator
    {

        public int addition(params int[] lst)
        {
            int total = 0;
            foreach (int num in lst)
            {
                total += num;
            }
            return total;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For each loop with Params");
            Calculator obj = new Calculator();

            Console.WriteLine(obj.addition(12, 35));
            Console.WriteLine(obj.addition(12, 35, 34));
            Console.WriteLine(obj.addition(1, 2, 85, 4, 5, 76, 7));

        }
    }
}


