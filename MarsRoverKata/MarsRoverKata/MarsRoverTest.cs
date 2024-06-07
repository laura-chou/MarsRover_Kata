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
        public void A01_RoverForward(string commands, string position)
        {
            var actual = _marsRover.Execute(commands);
            actual.Should().Be(position);
        }
    }
}