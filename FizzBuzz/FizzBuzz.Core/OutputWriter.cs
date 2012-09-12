using System;
using System.Text;

namespace FizzBuzz.Core
{
    public class OutputWriter : IOutputWriter
    {
        private WriteMode _mode;
        public StringBuilder Builder { get; set; }

        public OutputWriter()
        {
            Builder = new StringBuilder();
        }

        public void SetMode(WriteMode mode)
        {
            _mode = mode;
        }

        public void WriteLine(string line)
        {
            if (_mode == WriteMode.File)
                Builder.AppendLine(line);
            else if (_mode == WriteMode.Console)
                Console.WriteLine(line);
        }

        public void WriteFile(string path)
        {
            System.IO.File.WriteAllText(path, Builder.ToString());
        }
    }
}