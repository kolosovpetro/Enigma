using Enigma.Implementations;
using FluentAssertions;
using NUnit.Framework;

namespace Enigma.Tests.RotorSetTests
{
    [TestFixture]
    public class RotorSetTwoRotorsInitializationTest
    {
        [Test]
        public void RotorSet_TwoRotors_Initialization_Test()
        {
            var rotorSet = new RotorSet(2);
            rotorSet.Rotors.Count.Should().Be(2);
            rotorSet.Rotors[0].Position.Should().Be(0);
            rotorSet.Rotors[1].Position.Should().Be(0);
        }

        [Test]
        public void RotorSet_TwoRotors_ArrayInitialization_Test()
        {
            var positions = new[] {3, 2};
            var rotorSet = new RotorSet(positions);
            rotorSet.Rotors.Count.Should().Be(2);
            rotorSet.Rotors[0].Position.Should().Be(3);
            rotorSet.Rotors[1].Position.Should().Be(2);
        }
        
        [Test]
        public void RotorSet_TwoRotors_ArrayOverflowInitialization_Test()
        {
            var positions = new[] {30, 2};
            var rotorSet = new RotorSet(positions);
            rotorSet.Rotors.Count.Should().Be(2);
            rotorSet.Rotors[0].Position.Should().Be(30);
            rotorSet.Rotors[0].TotalRotationsCount.Should().Be(1);
            rotorSet.Rotors[1].Position.Should().Be(2);
            rotorSet.Rotors[1].TotalRotationsCount.Should().Be(0);
        }
        
        [Test]
        public void RotorSet_TwoRotors_ArrayOverflowInitializationNegative_Test()
        {
            var positions = new[] {-30, 2};
            var rotorSet = new RotorSet(positions);
            rotorSet.Rotors.Count.Should().Be(2);
            rotorSet.Rotors[0].Position.Should().Be(-30);
            rotorSet.Rotors[0].TotalRotationsCount.Should().Be(-1);
            rotorSet.Rotors[1].Position.Should().Be(2);
            rotorSet.Rotors[1].TotalRotationsCount.Should().Be(0);
        }
    }
}