using Enigma.Implementations;
using Enigma.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace Enigma.Tests.RotorTests
{
    [TestFixture]
    public class DoubleRotorEncryptionTest
    {
        [Test]
        public void Double_Rotor_Encrypt_Test()
        {
            IRotor rotor = new Rotor(0, 2);
            rotor.NextRotor.NextRotor.Should().BeNull();
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(16);
        }
    }
}