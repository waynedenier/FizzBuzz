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
            for (int i = 0; i < 100; i++)
            {
                Writer().WriteLine("foo");
            }
        }
    }
}
