using Enigma.Implementations;
using FluentAssertions;
using NUnit.Framework;

namespace Enigma.Tests.RotorSetTests
{
    [TestFixture]
    public class RotorSetLeftRotationTest
    {
        [Test]
        public void RotorSet_DoubleRightRotation_Test()
        {
            var rotorSet = new RotorSet(2);
            rotorSet.LeftRotate(30);
            rotorSet.Rotors[0].Position.Should().Be(-30);
            rotorSet.Rotors[1].Position.Should().Be(-1);
        }
        
        [Test]
        public void RotorSet_DoubleRightRotation_Test_2()
        {
            var rotorSet = new RotorSet(2);
            rotorSet.LeftRotate(60);
            rotorSet.Rotors[0].Position.Should().Be(-60);
            rotorSet.Rotors[1].Position.Should().Be(-2);
        }
        
        [Test]
        public void TripleRotorSet_TripleRightRotation_Test()
        {
            var rotorSet = new RotorSet(3);
            rotorSet.LeftRotate(677);
            rotorSet.Rotors[0].Position.Should().Be(-677);
            rotorSet.Rotors[1].Position.Should().Be(-25);
            rotorSet.Rotors[2].Position.Should().Be(0);
        }
    }
}