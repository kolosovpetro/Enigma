using Enigma.Enums;
using Enigma.Interfaces;

namespace Enigma.Implementations
{
    public class RotorState : IRotorState
    {
        public Direction Direction { get; set; }
        public int Value { get; set; }
    }
}