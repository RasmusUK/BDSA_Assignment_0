using System;
using System.IO;
using Xunit;

namespace Assignment.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void IsLeapYearThenTrue()
        {
            var notDivisibleByFour = Program.IsLeapYear(2001);
            var divisibleByFour = Program.IsLeapYear(2004);
            var divisibleByFourAndHundred = Program.IsLeapYear(1600);
            var divisibleByFourAndNotHundred = Program.IsLeapYear(1700);
            var yearOnLimit = Program.IsLeapYear(1581);
            var yearBeforeLimit = Program.IsLeapYear(800);

            Assert.False(yearOnLimit);
            Assert.False(yearBeforeLimit);
            Assert.False(notDivisibleByFour);
            Assert.True(divisibleByFour);
            Assert.True(divisibleByFourAndHundred);
            Assert.False(divisibleByFourAndNotHundred);
        }

        [Fact]
        public void UserInputWriteYay()
        {
            var actual = Program.GetLeapYearResponse("2004");
            
            Assert.Equal("yay", actual);
        }

        [Fact]
        public void UserInputWriteNay()
        {
            var actual = Program.GetLeapYearResponse("2001");

            Assert.Equal("nay", actual);
        }

        [Fact]
        public void UserInputNotInteger()
        {
            var actual = Program.GetLeapYearResponse("20ab");

            Assert.Equal("Please input a valid input", actual);
        }
    }
}