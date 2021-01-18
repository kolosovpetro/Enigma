using Enigma.Implementations;
using Enigma.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace Enigma.Tests.RotorTests
{
    [TestFixture]
    public class RotorDoubleLeftRotation
    {
        [Test]
        public void Rotor_DoubleLeftRotation_Test()
        {
            IRotor rotor = new Rotor();
            rotor.NextRotor = new Rotor();
            rotor.LeftRotate(75);
            rotor.RotorState.Should().Be(-75);
            rotor.NextRotor.RotorState.Should().Be(-2);
        }
        
        [Test]
        public void Rotor_DoubleLeftRotation_Test_2()
        {
            IRotor rotor = new Rotor();
            rotor.NextRotor = new Rotor();
            rotor.LeftRotate(26);
            rotor.RotorState.Should().Be(-26);
            rotor.NextRotor.RotorState.Should().Be(-1);
            rotor.LeftRotate(30);
            rotor.RotorState.Should().Be(-56);
            rotor.NextRotor.RotorState.Should().Be(-2);
            rotor.LeftRotate(30);
            rotor.RotorState.Should().Be(-86);
            rotor.NextRotor.RotorState.Should().Be(-3);
        }
    }
}