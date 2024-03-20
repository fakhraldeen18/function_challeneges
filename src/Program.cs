using System;
using System.Text;
using Microsoft.VisualBasic;

namespace FunctionChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Challenge 1: String and Number Processor
            Console.WriteLine("Challenge 1: String and Number Processor");
            object StringNumberProcessor(params object[] stingNumber)
            {
                StringBuilder concatString = new();
                int sum = 0;

                foreach (var item in stingNumber)
                {
                    if (item.GetType() == typeof(string))
                    {
                        concatString.Append(item);
                    }
                    else if (item.GetType() == typeof(int))
                    {
                        sum += (int)item;
                    }

                }
                return (concatString, sum);
            }
            Console.WriteLine($"result is  {StringNumberProcessor("Hello", 100, 200, " World")}");


        }
    }
}
