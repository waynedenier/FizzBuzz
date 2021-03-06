namespace FizzBuzz.Core
{
    public class FizzBuzzArgs
    {
        public int Lower { get; set; }
        public int Upper { get; set; }
        public string FizzToken { get; set; }
        public string BuzzToken { get; set; }
        public string OutputPath { get; set; }

        public FizzBuzzArgs()
        {
            FizzToken = "Fizz";
            BuzzToken = "Buzz";
        }
    }
}