using Enigma.Implementations;
using Enigma.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace Enigma.Tests.RotorTests
{
    [TestFixture]
    public class RotorEncryptionDecryptionTest
    {
        [Test]
        public void Rotor_Encrypt_Decrypt_Test()
        {
            IRotor rotor = new Rotor();
            var index1 = rotor.GetEncryptedIndexAndRotate(0);
            var index2 = rotor.GetEncryptedIndexAndRotate(0);
            index1.Should().Be(20);
            index2.Should().Be(17);
            var decrypt1 = rotor.GetDecryptedIndexAndRotate(index2);
            var decrypt2 = rotor.GetDecryptedIndexAndRotate(index1);
            decrypt1.Should().Be(0);
            decrypt2.Should().Be(0);
        }
        
        [Test]
        public void Rotor_Encrypt_Decrypt_Test_2()
        {
            IRotor rotor = new Rotor();
            var index1 = rotor.GetEncryptedIndexAndRotate(0);
            var index2 = rotor.GetEncryptedIndexAndRotate(1);
            index1.Should().Be(20);
            index2.Should().Be(20);
            var decrypt1 = rotor.GetDecryptedIndexAndRotate(index2);
            var decrypt2 = rotor.GetDecryptedIndexAndRotate(index1);
            decrypt1.Should().Be(1);
            decrypt2.Should().Be(0);
        }
    }
}