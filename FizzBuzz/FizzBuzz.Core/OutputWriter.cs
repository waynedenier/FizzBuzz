using System;
using System.Text;

namespace FizzBuzz.Core
{
    public class OutputWriter : IOutputWriter
    {
        public WriteMode Mode { get; set; }
        public StringBuilder Builder { get; set; }

        public OutputWriter()
        {
            Builder = new StringBuilder();
        }

        public void WriteLine(string line)
        {
            if (Mode == WriteMode.File)
                Builder.AppendLine(line);
            else if (Mode == WriteMode.Console)
                Console.WriteLine(line);
        }

        public void WriteFile(string path)
        {
            System.IO.File.WriteAllText(path, Builder.ToString());
        }
    }
}