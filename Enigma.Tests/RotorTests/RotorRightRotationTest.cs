using Enigma.Implementations;
using Enigma.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace Enigma.Tests.RotorTests
{
    [TestFixture]
    public class RotorRightRotationTest
    {
        [Test]
        public void Rotor_RightRotation_Test()
        {
            IRotor rotor = new Rotor();
            rotor.GetEncryptedIndex(0).Should().Be(20);
            rotor.GetEncryptedIndex(0).Should().Be(25);
            rotor.GetEncryptedIndex(0).Should().Be(8);
            rotor.RotorState.Should().Be(3);
        }

        [Test]
        public void Rotor_RightRotation_CustomShift_Test()
        {
            IRotor rotor = new Rotor();
            rotor.RightRotate(10);
            rotor.GetEncryptedIndex(0).Should().Be(23);
            rotor.GetEncryptedIndex(0).Should().Be(19);
            rotor.RotorState.Should().Be(12);
        }

        [Test]
        public void Rotor_RightRotation_Overflow_Test()
        {
            IRotor rotor = new Rotor();
            rotor.RightRotate(36);
            rotor.GetEncryptedIndex(0).Should().Be(23);
            rotor.GetEncryptedIndex(0).Should().Be(19);
            rotor.RotorState.Should().Be(12);
        }
    }
}