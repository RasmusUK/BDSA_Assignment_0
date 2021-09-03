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

        [Fact]
        public void IsLeapYearThenTrue()
        {
            var notDivisibleByFour = Program.IsLeapYear(2001);
            var divisibleByFour = Program.IsLeapYear(2004);
            var divisibleByFourAndHundred = Program.IsLeapYear(1600);
            var divisibleByFourAndNotHundred = Program.IsLeapYear(1700);

            Assert.False(notDivisibleByFour);
            Assert.True(divisibleByFour);
            Assert.True(divisibleByFourAndHundred);
            Assert.False(divisibleByFourAndNotHundred);
        }
    }
}