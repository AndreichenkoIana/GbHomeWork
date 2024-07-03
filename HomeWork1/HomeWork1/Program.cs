using System;

namespace HomeWork;

internal class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 3)
        {
            int result = 0;
            int num1 = int.Parse(args[0]);
            string operation = args[1];
            int num2 = int.Parse(args[2]);
            if (operation == "+")
            {
                result = num1 + num2;
            }
            if (operation == "-")
            {
                result = num1 - num2;
            }
            if (operation == "/")
            {
                result = num1 / num2;
            }
            if (operation == "*")
            {
                result = num1 * num2;
            }
            Console.WriteLine($" {num1} {operation} {num2} = {result} ");
        }
        else
            Console.WriteLine("Для использования программы введите: число знак(+-/*) число");

    }
}
