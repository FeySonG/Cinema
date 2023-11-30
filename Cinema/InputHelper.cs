using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class InputHelper
    {
        public static string InputString(string inputMessage)
        {
            Console.WriteLine(inputMessage);
            string value = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(value))
            {
                return value;
            }

            Console.WriteLine("Please try again");
            return InputString(inputMessage);
        }
        public static int ReadNumber(string inputMessage)
        {
            string value = InputString(inputMessage);
            if (int.TryParse(value, out int number))
            {
                return number;
            }

            Console.WriteLine("Input number using digits");
            return ReadNumber(inputMessage);
        }

        public static long ReadLong(string inputMessage)
        {
           string value = InputString(inputMessage) ;  
         
            if (long.TryParse(value, out long number))
            {
                return number;
            }

            Console.WriteLine("Input number using digits");
            return ReadLong(inputMessage);
        }




    }
   
}
