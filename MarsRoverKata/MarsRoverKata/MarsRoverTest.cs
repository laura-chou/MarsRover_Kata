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
        [TestCase("MMMMMMMMMM", "0:9:N")]
        public void A01_RoverForward(string commands, string position)
        {
            AssertResultShouldReturn(commands, position);
        }
        
        [Test]
        [TestCase("R", "0:0:E")]
        [TestCase("RR", "0:0:S")]
        [TestCase("RRR", "0:0:W")]
        [TestCase("RRRR", "0:0:N")]
        [TestCase("MMMRM", "1:3:E")]
        [TestCase("RMMMMMMMMMM", "9:0:E")]
        public void A02_RoverTurnRightAndForward(string commands, string position)
        {
            AssertResultShouldReturn(commands, position);
        }

        [Test]
        [TestCase("L", "0:0:W")]
        [TestCase("LL", "0:0:S")]
        [TestCase("LLL", "0:0:E")]
        public void A03_RoverTurnLeftAndForward(string commands, string position)
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