namespace Enigma.Interfaces
{
    public interface IRotorPosition
    {
        int RotorsCount { get; set; }
        int[] Positions { get; set; }
    }
}