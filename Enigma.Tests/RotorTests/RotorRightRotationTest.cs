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
        public void Rotor_RightRotation_Simple_Test()
        {
            IRotor rotor = new Rotor();
            rotor.RightRotate(3);
            rotor.GetEncryptedIndex(0).Should().Be(22);
            rotor.GetEncryptedIndex(0).Should().Be(13);
            rotor.GetEncryptedIndex(0).Should().Be(9);
            rotor.RotorState.Should().Be(6);
        }

        [Test]
        public void Rotor_RightRotation_Simple_Test_2()
        {
            IRotor rotor = new Rotor();
            rotor.LeftRotate();
            rotor.GetEncryptedIndex(0).Should().Be(25);
            rotor.LeftRotate();
            rotor.GetEncryptedIndex(0).Should().Be(25);
            rotor.LeftRotate();
            rotor.GetEncryptedIndex(0).Should().Be(25);
            rotor.LeftRotate();
            rotor.GetEncryptedIndex(0).Should().Be(25);
        }
    }
}