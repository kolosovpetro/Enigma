namespace Enigma.Interfaces
{
    public interface IRotor
    {
        IRotor NextRotor { get; set; }
        int RotorState { get; }
        int GetEncryptedIndex(int index);
        int GetEncryptedIndexAndRotate(int index);
        int GetDecryptedIndexAndRotate(int index);
        int RotorIndexOf(int value);
        void LeftRotate();
        void LeftRotate(int shift);
        void RightRotate();
        void RightRotate(int shift);
    }
}