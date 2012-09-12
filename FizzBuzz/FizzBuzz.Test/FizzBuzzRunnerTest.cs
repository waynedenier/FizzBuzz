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
        private MockRepository _mockRepository = new MockRepository();

        [TestMethod]
        public void When_Run_Is_Called_Should_Write_100_Lines()
        {
            // create runner and writer
            var runner = new FizzBuzzRunner();

            // set up writer to track number of lines writen
            var consoleWriter = _mockRepository.Stub<IConsoleWriter>();
            int linesPrinted = 0;
            consoleWriter.Stub(x => x.WriteLine(null)).IgnoreArguments().WhenCalled((x) => linesPrinted++);
            runner.Writer = () => consoleWriter;

            // run fizz buzz
            runner.Run();

            // should have writen 100 lines
            linesPrinted.ShouldEqual(100);
        }
    }
}
