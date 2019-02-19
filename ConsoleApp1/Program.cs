using System;

namespace ConsoleApp1
{// how to run FIZZ BUZZ
    class Program
    {
        static void Main(string[] args)
        {
            // var for multiples
            var F = 3;
            var B = 5;

            //main loop thst goes until 100
            for (int x = 1; x < 101; x++)
            {
                Console.Write(x);
                // for multiples of 3 and 5 
                if (x % F == 0 && x % B == 0)
                { Console.WriteLine("Fizz Buzz"); }

                // for multiples of just 3 
                else if (x % F == 0)
                { Console.WriteLine("fizz"); }

                // for multiples of just 5
                else if (x % B == 0)
                { Console.WriteLine("buzz"); }
                // for writing the number sequence
                else { Console.WriteLine(x); }

                
            }

              

        }
    }
}

