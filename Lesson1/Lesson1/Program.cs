using Animal1;
using System;

namespace Lesson1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length > 1)
            {
                //int num1 = int.Parse(args[0]);
                //int num2 = int.Parse(args[1]);

                //int sum = num1 + num2;
                //Console.WriteLine($" {num1} + {num2} = {sum}");

                //foreach (string item in args)
                //{
                //    Console.Write($"{item} ,");
                //}
                //Console.WriteLine(string.Join(", ", args));

                int sum = 0;
                int [] array = Array.ConvertAll(args,int.Parse);
                //foreach (string arg in args)
                //{
                //    sum += int.Parse(arg);
                //}
                
                int avg = array.Sum() / args.Length;
                Console.WriteLine(avg);
            }
            else
            {
                Console.WriteLine("Need args");
            }
        }
    }
}