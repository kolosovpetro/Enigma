using Enigma.Implementations;
using Enigma.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace Enigma.Tests.RotorTests
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
            rotor.GetEncryptedIndex(0).Should().Be(20);
            rotor.GetEncryptedIndex(0).Should().Be(17);
            rotor.GetEncryptedIndex(0).Should().Be(5);
            rotor.RotorState.Should().Be(3);
        }
    }
}