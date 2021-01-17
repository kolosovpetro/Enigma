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
            rotor.RightRotate();
            rotor.GetEncryptedIndex(0).Should().Be(17);
            rotor.GetEncryptedIndex(0).Should().Be(5);
        }
    }
}