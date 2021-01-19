using Enigma.Implementations;
using Enigma.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace Enigma.Tests.RotorInitializationTests
{
    [TestFixture]
    public class RotorInitWithRotorPositionInstanceTest
    {
        [Test]
        public void SingleRotor_Initialization_Test()
        {
            IRotorPosition rotorPosition = new RotorPosition(1, new[] {0});
            IRotor rotor = new Rotor(rotorPosition);
            rotor.RotorState.Should().Be(0);
            rotor.NextRotor.Should().BeNull();
            rotor.PreviousRotor.Should().BeNull();
        }

        [Test]
        public void DoubleRotor_Initialization_CustomPosition_Test()
        {
            IRotorPosition rotorPosition = new RotorPosition(2, new[] {3, 2});
            IRotor rotor = new Rotor(rotorPosition);
            rotor.PreviousRotor.Should().BeNull();
            rotor.RotorState.Should().Be(3);
            rotor.NextRotor.RotorState.Should().Be(2);
            rotor.NextRotor.PreviousRotor.RotorState.Should().Be(3);
            rotor.NextRotor.NextRotor.Should().BeNull();

        }
    }
}