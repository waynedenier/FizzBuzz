using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz.Core
{
    public class FizzBuzzRunner
    {
        public Func<IConsoleWriter> Writer = () => new ConsoleWriter();

        public void Run()
        {
            for (int i = 1; i <= 100; i++)
            {
                string result = "";

                if (i % 3 == 0)
                    result += "Fizz";
                
                if (i % 5 == 0)
                    result += "Buzz";
                
                Writer().WriteLine(result);
            }
        }
    }
}
