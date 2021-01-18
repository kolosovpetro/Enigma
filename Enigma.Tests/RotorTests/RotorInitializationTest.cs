using Enigma.Implementations;
using Enigma.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace Enigma.Tests.RotorTests
{
    [TestFixture]
    public class RotorInitializationTest
    {
        [Test]
        public void Rotor_Initialization_Simple_Test()
        {
            IRotor rotor = new Rotor(0, 2);
            rotor.NextRotor.Should().NotBeNull();
            rotor.RotorState.Should().Be(0);
            rotor.NextRotor.RotorState.Should().Be(0);
        }

        [Test]
        public void Rotor_Initialization_With_State_Positive()
        {
            IRotor rotor = new Rotor(86, 2);
            rotor.NextRotor.Should().NotBeNull();
            rotor.RotorState.Should().Be(86);
            rotor.NextRotor.RotorState.Should().Be(3);
        }

        [Test]
        public void Rotor_Initialization_With_State_Negative()
        {
            IRotor rotor = new Rotor(0, 2);
            rotor.LeftRotate(86);
            rotor.NextRotor.Should().NotBeNull();
            rotor.RotorState.Should().Be(-86);
            rotor.NextRotor.RotorState.Should().Be(-3);
        }
    }
}