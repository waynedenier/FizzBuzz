using System.Collections.Generic;
using System.Linq;
using System.Text;
using FizzBuzz.Core;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var parsedArgs = ArgumentParser.Parse(args);
            var runner = new FizzBuzzRunner();
            
            runner.Run(parsedArgs);
        }
    }
}
