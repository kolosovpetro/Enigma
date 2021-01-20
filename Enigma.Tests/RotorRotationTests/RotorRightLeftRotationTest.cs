using Enigma.Implementations;
using Enigma.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace Enigma.Tests.RotorRotationTests
{
    [TestFixture]
    public class RotorRightLeftRotationTest
    {
        [Test]
        public void Rotor_RightLeftRotation_Test()
        {
            IRotor rotor = new Rotor();
            rotor.RightRotate(5);
            rotor.LeftRotate(5);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(20);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(26);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(17);
            rotor.Position.Should().Be(3);
        }
        
        [Test]
        public void Rotor_LeftRightRotation_Test()
        {
            IRotor rotor = new Rotor();
            rotor.LeftRotate(5);
            rotor.RightRotate(5);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(20);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(26);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(17);
            rotor.Position.Should().Be(3);
        }
    }
}