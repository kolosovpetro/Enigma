using Enigma.Implementations;
using Enigma.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace Enigma.Tests.RotorTests
{
    [TestFixture]
    public class RotorLeftRotationTest
    {
        [Test]
        public void Rotor_LeftRotation_Test()
        {
            IRotor rotor = new Rotor();
            rotor.GetEncryptedIndex(0).Should().Be(20);
            rotor.GetEncryptedIndex(0).Should().Be(17);
            rotor.GetEncryptedIndex(0).Should().Be(5);
            rotor.RotorState.Should().Be(3);
        }

        [Test]
        public void Rotor_LeftRotation_CustomShift_Test()
        {
            IRotor rotor = new Rotor();
            rotor.LeftRotate(10);
            rotor.GetEncryptedIndex(0).Should().Be(23);
            rotor.GetEncryptedIndex(0).Should().Be(7);
            rotor.RotorState.Should().Be(-8);
        }

        [Test]
        public void Rotor_LeftRotation_Overflow_Test()
        {
            IRotor rotor = new Rotor();
            rotor.LeftRotate(36);
            rotor.GetEncryptedIndex(0).Should().Be(23);
            rotor.GetEncryptedIndex(0).Should().Be(7);
            rotor.GetEncryptedIndex(0).Should().Be(12);
            rotor.RotorState.Should().Be(-7);
        }
    }
}