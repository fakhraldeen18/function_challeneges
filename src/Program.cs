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


            // Challenge 2: Object Swapper
            Console.WriteLine("\nChallenge 2: Object Swapper");
            object num1 = 25, num2 = 30;
            object num3 = 10, num4 = 30;
            object str1 = "HelloWorld", str2 = "Programming";
            object str3 = "Hi", str4 = "Programming";
            object True = true, False = false;

            void SwapObjects(ref object input1, ref object input2)
            {
                if (input1 is int a && input2 is int b)
                {
                    if (a > 18 && b > 18)
                    {

                        int nu1 = a;
                        int nu2 = b;
                        input1 = nu2;
                        input2 = nu1;
                        Console.WriteLine($"num1 = {input1}, num2 = {input2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Value must be more than 18");
                    }
                }

                else if (input1 is string c && input2 is string d)
                {
                    if (c.Length > 5 && d.Length > 5)
                    {

                        string str1 = c;
                        string str2 = d;
                        input1 = str2;
                        input2 = str1;
                        Console.WriteLine($"str1 = {input1}, str2 = {input2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Length must be more than 5");
                    }
                }
                else if (input1 is not string && input2 is not int)
                {
                    Console.WriteLine("Error: Unsupported data type");
                }
                else if (input1 is not string || input2 is int)
                {
                    Console.WriteLine("Error: Objects must be of same types");
                }
            }

            SwapObjects(ref num1, ref num2); // Expected outcome: num1 = 30, num2 = 25  
            SwapObjects(ref num3, ref num4); // Error: Value must be more than 18

            SwapObjects(ref str1, ref str2); // Expected outcome: str1 = "Programming", str2 = "HelloWorld"
            SwapObjects(ref str3, ref str4); // Error: Length must be more than 5

            SwapObjects(ref True, ref False); // Error: Unsupported data type
            SwapObjects(ref num1, ref str1); // Error: Objects must be of same types

            Console.WriteLine($"Numbers: {num1}, {num2}");
            Console.WriteLine($"Strings: {str1}, {str2}");

        }
    }
}
