namespace FizzBuzz.Core
{
    public interface IOutputWriter
    {
        void WriteLine(string line);
        void WriteFile(string path);
    }
}