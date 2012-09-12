using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz.Core
{
    public class FizzBuzzRunner
    {
        public Func<IConsoleWriter> Writer = () => new ConsoleWriter();

        public void Run(FizzBuzzArgs args)
        {
            for (int i = args.Lower; i <= args.Upper; i++)
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
