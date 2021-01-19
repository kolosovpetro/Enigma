using Enigma.Interfaces;

namespace Enigma.Implementations
{
    public class RotorPosition : IRotorPosition
    {
        public int RotorsCount { get; set; }
        public int[] RotorsPositions { get; set; }
    }
}