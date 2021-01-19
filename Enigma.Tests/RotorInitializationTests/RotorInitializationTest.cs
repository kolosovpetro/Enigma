using Enigma.Implementations;
using Enigma.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace Enigma.Tests.RotorInitializationTests
{
    [TestFixture]
    public class RotorInitializationTest
    {
        [Test]
        public void Rotor_Initialization_Test()
        {
            new Rotor(35).Position.Should().Be(35);
            new Rotor(-35).Position.Should().Be(-35);
        }
    }
}