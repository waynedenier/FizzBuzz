namespace FizzBuzz.Core
{
    public interface IOutputWriter
    {
        void SetMode(WriteMode mode);
        void WriteLine(string line);
        void WriteFile(string path);
    }
}