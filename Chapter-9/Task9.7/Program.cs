using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9._7
{
    class Program
    {
        public static string Reverse(string number)

        {

            char[] charArray = number.ToCharArray();

            Array.Reverse(charArray);

            return new string(charArray);

        }



        static void Main()

        {

            Console.Write("Enter number: ");

            string number = Console.ReadLine();



            Console.WriteLine(Reverse(number));

        }
    }
}
