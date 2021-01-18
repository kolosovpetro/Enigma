namespace Enigma.Interfaces
{
    public interface IRotor
    {
        IRotor NextRotor { get; set; }
        int RotorState { get; }
        int GetEncryptedIndex(int index);
        int GetEncryptedIndexAndRotate(int index);
        void LeftRotate();
        void LeftRotate(int shift);
        void RightRotate();
        void RightRotate(int shift);
    }
}