using Enigma.Enums;

namespace Enigma.Interfaces
{
    public interface IRotorState
    {
        Direction Direction { get; set; }
        int Value { get; set; }
    }
}