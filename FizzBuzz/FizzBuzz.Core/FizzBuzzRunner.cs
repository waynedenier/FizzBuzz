using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz.Core
{
    public class FizzBuzzRunner
    {
        public Func<IConsoleWriter> Writer = () => new ConsoleWriter();

        public void Run(int lower, int upper)
        {
            for (int i = 1; i <= 100; i++)
            {
                string result = null;

                if (i % 3 == 0)
                    result += "Fizz";
                
                if (i % 5 == 0)
                    result += "Buzz";

                if (result == null)
                    result = i.ToString();

                Writer().WriteLine(result);
            }
        }
    }
}
