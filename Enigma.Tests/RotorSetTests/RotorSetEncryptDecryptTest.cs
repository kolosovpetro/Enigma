using Enigma.Implementations;
using FluentAssertions;
using NUnit.Framework;

namespace Enigma.Tests.RotorSetTests
{
    [TestFixture]
    public class RotorSetEncryptDecryptTest
    {
        [Test]
        public void SingleRotorSet_EncryptDecrypt_Test()
        {
            var rotorSet = new RotorSet(1);
            var encryptIndex = rotorSet.GetEncryptedIndexAndRotate(2);
            var decryptIndex = rotorSet.GetDecryptedIndexAndRotate(encryptIndex);
            decryptIndex.Should().Be(2);
        }

        [Test]
        public void DoubleRotorSet_EncryptDecrypt_Test()
        {
            var rotorSet = new RotorSet(2);
            var encryptIndex = rotorSet.GetEncryptedIndexAndRotate(2);
            var decryptIndex = rotorSet.GetDecryptedIndexAndRotate(encryptIndex);
            decryptIndex.Should().Be(2);
        }

        [Test]
        public void DoubleRotorSet_EncryptDecrypt_Overloaded_Test()
        {
            var rotorSet = new RotorSet(new[] {3, 4});
            var encryptIndex = rotorSet.GetEncryptedIndexAndRotate(2);
            var decryptIndex = rotorSet.GetDecryptedIndexAndRotate(encryptIndex);
            decryptIndex.Should().Be(2);
        }

        [Test]
        public void TripleRotorSet_EncryptDecrypt_Overloaded_Test()
        {
            var rotorSet = new RotorSet(new[] {3, 4, 5});
            var encryptIndex = rotorSet.GetEncryptedIndexAndRotate(2);
            var decryptIndex = rotorSet.GetDecryptedIndexAndRotate(encryptIndex);
            decryptIndex.Should().Be(2);
        }
    }
}