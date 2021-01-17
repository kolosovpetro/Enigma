namespace Enigma.Interfaces
{
    public interface IRotor
    {
        int CurrentState { get; }
        void Rotate();
    }
}