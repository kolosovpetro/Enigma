using Enigma.Implementations;
using Enigma.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace Enigma.Tests.RotorRotationTests
{
    [TestFixture]
    public class RotorRightRotationTest
    {
        [Test]
        public void Rotor_RightRotation_Simple_Test()
        {
            IRotor rotor = new Rotor();
            rotor.RightRotate(3);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(5);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(22);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(13);
            rotor.Position.Should().Be(6);
        }
        
        [Test]
        public void Rotor_RightRotation_Overflow_Test()
        {
            IRotor rotor = new Rotor();
            rotor.RightRotate(29);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(17);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(5);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(22);
            rotor.Position.Should().Be(32);
        }

        [Test]
        public void Rotor_RightRotation_Simple_Test_2()
        {
            IRotor rotor = new Rotor();
            rotor.LeftRotate(1);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(25);
            rotor.LeftRotate(1);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(25);
            rotor.LeftRotate(1);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(25);
            rotor.LeftRotate(1);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(25);
        }
    }
}