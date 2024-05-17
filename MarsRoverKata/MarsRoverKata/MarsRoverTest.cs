using MarsRoverKata.src;
using FluentAssertions;
using NUnit.Framework;

namespace MarsRoverKata
{
    [TestFixture]
    public class MarsRoverTest
    {
        private MarsRover _marsRover;
        
        [SetUp]
        public void A00_Setup()
        {
            _marsRover = new MarsRover();
        }

        [Test]
        [TestCase("M", "0:1:N")]
        [TestCase("MMM", "0:3:N")]
        public void A01_GoStraight(string commands, string position)
        {
            AssertResultShouldReturn(commands, position);
        }

        [TestCase("R", "0:0:E")]
        [TestCase("RR", "0:0:S")]
        [TestCase("RRR", "0:0:W")]
        [TestCase("RRRR", "0:0:N")]
        [TestCase("MMMRM", "1:3:E")]
        [TestCase("MMMMRMMM", "3:4:E")]
        public void A02_TurnRight(string commands, string position)
        {
            AssertResultShouldReturn(commands, position);
        }

        [TestCase("L", "0:0:W")]
        [TestCase("LL", "0:0:S")]
        [TestCase("LLL", "0:0:E")]
        [TestCase("LLLL", "0:0:N")]
        [TestCase("LLLL", "0:0:N")]
        [TestCase("RMMMLM", "3:1:N")]
        [TestCase("MRMMMMLMMMML", "4:5:W")]
        public void A03_TurnLeft(string commands, string position)
        {
            AssertResultShouldReturn(commands, position);
        }
        
        [TestCase("MMMMMMMMMMRM", "1:9:E")]
        [TestCase("RMMMMMMMMMMLM", "9:1:N")]
        [TestCase("MMMMMMLM", "0:6:W")]
        public void A04_EndOfTheGrid(string commands, string position)
        {
            AssertResultShouldReturn(commands, position);
        }

        private void AssertResultShouldReturn(string commands, string position)
        {
            var actual = _marsRover.Execute(commands);
            actual.Should().Be(position);
        }
    }
}