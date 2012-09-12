using System;

namespace FizzBuzz.Core
{
    public class ArgumentParser
    {
        public static FizzBuzzArgs Parse(string[] args)
        {
            return Args.Configuration.Configure<FizzBuzzArgs>().CreateAndBind(args);
        }
    }
}