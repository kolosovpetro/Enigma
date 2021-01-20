using Enigma.Implementations;
using Enigma.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace Enigma.Tests.EnigmaTests
{
    [TestFixture]
    public class EnigmaSingleRotorEncryptDecryptTest
    {
        [Test]
        public void Enigma_EncryptDecrypt_Test()
        {
            IEnigma enigma = new Implementations.Enigma(new RotorSet(1));
            var encryptedMessage = enigma.EncryptMessage("ABCD");
            encryptedMessage.Message.Should().Be("UUUU");
            var decryptedMessage = enigma.DecryptMessage(encryptedMessage);
            decryptedMessage.Should().Be("ABCD");
        }
        
        [Test]
        public void Enigma_EncryptDecrypt_Test_2()
        {
            IEnigma enigma = new Implementations.Enigma(new RotorSet(1));
            var encryptedMessage = enigma.EncryptMessage("E");
            encryptedMessage.Message.Should().Be("P");
            var encrypted = enigma.DecryptMessage(encryptedMessage);
            encrypted.Should().Be("E");
        }
    }
}