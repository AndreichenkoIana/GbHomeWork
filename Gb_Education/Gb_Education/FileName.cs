using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gb_Education
{
    internal class FileName
    {
        static void Main ()
        {
            Console.WriteLine("Введите свое имя: ");
            var name = Console.ReadLine();
            var message = $"Привет, уважаемая {name}";
            Console.WriteLine(message);
        }
    }
}
