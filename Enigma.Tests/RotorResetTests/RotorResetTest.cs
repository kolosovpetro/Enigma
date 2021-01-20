using Enigma.Implementations;
using Enigma.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace Enigma.Tests.RotorResetTests
{
    [TestFixture]
    public class RotorResetTest
    {
        [Test]
        public void Rotor_Reset_Test()
        {
            IRotor rotor = new Rotor();
            rotor.RightRotate(26);
            rotor.Position.Should().Be(26);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(25);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(20);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(26);
            rotor.Reset();
            rotor.Position.Should().Be(0);
        }
    }
}