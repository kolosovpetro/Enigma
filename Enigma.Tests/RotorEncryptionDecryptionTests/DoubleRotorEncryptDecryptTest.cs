using Enigma.Implementations;
using Enigma.Interfaces;
using FluentAssertions;
using NUnit.Framework;

namespace Enigma.Tests.RotorEncryptionDecryptionTests
{
    [TestFixture]
    public class DoubleRotorEncryptDecryptTest
    {
        // [Test]
        // public void Rotor_Encrypt_Decrypt_Test_3()
        // {
        //     IRotor rotor = new Rotor(0, 2);
        //     var index1 = rotor.GetEncryptedIndexAndRotate(0);
        //     var index2 = rotor.GetEncryptedIndexAndRotate(1);
        //     index1.Should().Be(16);
        //     index2.Should().Be(16);
        //     var decrypt1 = rotor.GetDecryptedIndexAndRotate(index1);
        //     var decrypt2 = rotor.GetDecryptedIndexAndRotate(index2);
        //     decrypt1.Should().Be(1);
        //     decrypt2.Should().Be(0);
        // }
    }
}