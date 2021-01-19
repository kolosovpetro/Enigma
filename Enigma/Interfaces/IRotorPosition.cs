namespace Enigma.Interfaces
{
    public interface IRotorPosition
    {
        int RotorsCount { get; set; }
        int[] RotorsPositions { get; set; }
    }
}