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
        private FizzBuzzRunner _runner;
        private MockConsoleWriter _mockConsoleWriter;

        [TestInitialize]
        public void Init()
        {
            // create runner and writer
            _runner = new FizzBuzzRunner();

            // set up writer to track number of lines writen
            _mockConsoleWriter = new MockConsoleWriter();
            _runner.Writer = () => _mockConsoleWriter;
        }

        [TestMethod]
        public void When_Run_Is_Called_Should_Write_100_Lines()
        {
            // run fizz buzz
            _runner.Run(1, 100);

            // check lines
            _mockConsoleWriter.LinesWriten.ShouldEqual(100);
        }

        [TestMethod]
        public void When_Run_Is_Called_Should_Write_Number_of_Lines_based_on_first_and_second_arg()
        {
            // run fizz buzz
            _runner.Run(25,300);

            // check lines
            _mockConsoleWriter.LinesWriten.ShouldEqual(275);
        }

        [TestMethod]
        public void When_Run_Is_Called_Values_Divisable_By_3_Should_Print_Fizz()
        {
            // run fizz buzz
            _runner.Run(1,100);

            // check lines
            Assert.IsTrue(_mockConsoleWriter.Lines.Count >= 9);
            _mockConsoleWriter.Lines[2].ShouldEqual("Fizz");
            _mockConsoleWriter.Lines[5].ShouldEqual("Fizz");
            _mockConsoleWriter.Lines[8].ShouldEqual("Fizz");
        }

        [TestMethod]
        public void When_Run_Is_Called_Values_Divisable_By_5_Should_Print_Buzz()
        {
            // run fizz buzz
            _runner.Run(1,100);

            // check lines
            Assert.IsTrue(_mockConsoleWriter.Lines.Count >= 20);
            _mockConsoleWriter.Lines[4].ShouldEqual("Buzz");
            _mockConsoleWriter.Lines[9].ShouldEqual("Buzz");
            _mockConsoleWriter.Lines[19].ShouldEqual("Buzz");
        }

        [TestMethod]
        public void When_Run_Is_Called_Values_Divisable_By_3_and_5_Should_Print_FizzBuzz()
        {
            // run fizz buzz
            _runner.Run(1,100);

            // check lines
            Assert.IsTrue(_mockConsoleWriter.Lines.Count >= 45);
            _mockConsoleWriter.Lines[14].ShouldEqual("FizzBuzz");
            _mockConsoleWriter.Lines[29].ShouldEqual("FizzBuzz");
            _mockConsoleWriter.Lines[44].ShouldEqual("FizzBuzz");
        }
    }

    public class MockConsoleWriter : IConsoleWriter
    {
        public int LinesWriten = 0;
        public List<string> Lines = new List<string>();

        public void WriteLine(string line)
        {
            LinesWriten++;
            Lines.Add(line);
        }
    }
}
