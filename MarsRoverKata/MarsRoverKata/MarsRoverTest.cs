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
        public void A02_TurnRight(string commands, string position)
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