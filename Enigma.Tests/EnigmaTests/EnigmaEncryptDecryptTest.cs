using Enigma.Implementations;
using Enigma.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace Enigma.Tests.EnigmaTests
{
    [TestFixture]
    public class EnigmaEncryptDecryptTest
    {
        [Test]
        public void Enigma_EncryptDecrypt_Test()
        {
            IRotor rotor = new Rotor();
            IEnigma enigma = new Implementations.Enigma(rotor);
            var encryptedMessage = enigma.EncryptMessage("ABCD");
            encryptedMessage.Message.Should().Be("UUUU");
            encryptedMessage.RotorsPosition.Should().Be(4);
            var decryptedMessage = enigma.DecryptMessage(encryptedMessage);
            decryptedMessage.Should().Be("ABCD");
        }
    }
}