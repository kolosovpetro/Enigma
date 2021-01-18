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
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(10);
        }
        
        [Test]
        public void Double_Rotor_Encrypt_Test_2()
        {
            IRotor rotor = new Rotor(0, 2);
            rotor.RightRotate(26);
            rotor.RotorState.Should().Be(26);
            rotor.NextRotor.RotorState.Should().Be(1);
            rotor.NextRotor.NextRotor.Should().BeNull();
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(4);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(0);
            rotor.GetEncryptedIndexAndRotate(0).Should().Be(15);
        }
    }
}