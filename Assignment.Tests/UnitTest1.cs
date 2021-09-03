using System;
using System.IO;
using Xunit;

namespace Assignment.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_prints_Hello_World()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("Hello World!", output);
        }
    }
}