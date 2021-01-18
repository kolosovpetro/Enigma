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
            var encryptedMessage = enigma.EncryptMessage("ABC");
            encryptedMessage.Message.Should().Be("UUU");
            encryptedMessage.RotorsPosition.Should().Be(3);
            
            rotor = new Rotor(encryptedMessage.RotorsPosition, 1);
            enigma = new Implementations.Enigma(rotor);
            var decryptedMessage = enigma.DecryptMessage(encryptedMessage);
            decryptedMessage.Should().Be("ABC");
        }
    }
}