using System;
using Enigma.Interfaces;

namespace Enigma.Implementations
{
    public class RotorPosition : IRotorPosition
    {
        public int RotorsCount { get; set; }
        public int[] Positions { get; set; }

        public RotorPosition(int rotorsCount, int[] rotorsPositions)
        {
            if (rotorsCount != rotorsPositions.Length)
                throw new InvalidOperationException("Rotor positions should be equal to count.");
            
            RotorsCount = rotorsCount;
            Positions = rotorsPositions;
        }
    }
}