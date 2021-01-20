using Enigma.Implementations;
using Enigma.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace Enigma.Tests.RotorRotationTests
{
    [TestFixture]
    public class RotorLeftRotationTest
    {
        [Test]
        public void Rotor_LeftRotation_Test()
        {
            IRotor rotor = new Rotor();
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(20);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(26);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(17);
            rotor.Position.Should().Be(3);
        }

        [Test]
        public void Rotor_LeftRotation_CustomShift_Test()
        {
            IRotor rotor = new Rotor();
            rotor.LeftRotate(10);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(23);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(7);
            rotor.Position.Should().Be(-8);
        }

        [Test]
        public void Rotor_LeftRotation_Overflow_Test()
        {
            IRotor rotor = new Rotor();
            rotor.LeftRotate(36);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(7);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(12);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(21);
            rotor.Position.Should().Be(-33);
        }
    }
}