using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 1; number < 100; number++)

                if (number % 3 == 0 && number % 5 == 0)
                {

                    Console.WriteLine("FizzBuzz {0}",number);
                }

                else if (number % 3 == 0)
                {

                    Console.WriteLine("Fizz {0}", number);
                }

                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz {0}", number);
                }

                else
                {

                    Console.WriteLine("{0}",number);

                }
        }
    }
}
