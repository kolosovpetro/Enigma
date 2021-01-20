using Enigma.Implementations;
using Enigma.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace Enigma.Tests.RotorEncryptionDecryptionTests
{
    [TestFixture]
    public class SingleRotorEncryptDecryptTest
    {
        [Test]
        public void SingleRotor_EncryptDecrypt_Test_1()
        {
            IRotor rotor = new Rotor();
            var index1 = rotor.GetEncryptedIndexAndRotate(0);
            var index2 = rotor.GetEncryptedIndexAndRotate(0);
            index1.Should().Be(20);
            index2.Should().Be(26);
            var decrypt1 = rotor.GetDecryptedIndexAndRotate(index2);
            var decrypt2 = rotor.GetDecryptedIndexAndRotate(index1);
            decrypt1.Should().Be(0);
            decrypt2.Should().Be(0);
        }

        [Test]
        public void SingleRotor_EncryptDecrypt_Test_2()
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