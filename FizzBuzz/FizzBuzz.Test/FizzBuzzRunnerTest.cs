using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using FizzBuzz.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using Should;

namespace FizzBuzz.Test
{
    [TestClass]
    public class FizzBuzzRunnerTest
    {
        private readonly MockRepository _mockRepository = new MockRepository();

        [TestMethod]
        public void When_Run_Is_Called_Should_Write_100_Lines()
        {
            // create runner and writer
            var runner = new FizzBuzzRunner();

            // set up writer to track number of lines writen
            var mockConsoleWriter = new MockConsoleWriter();
            runner.Writer = () => mockConsoleWriter;

            // run fizz buzz
            runner.Run();

            // check lines
            mockConsoleWriter.LinesWriten.ShouldEqual(100);
        }
    }

    public class MockConsoleWriter : IConsoleWriter
    {
        public int LinesWriten = 0;

        public void WriteLine(string line)
        {
            LinesWriten++;
        }
    }
}
