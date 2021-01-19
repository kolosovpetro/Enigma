namespace Enigma.Interfaces
{
    public interface IRotor
    {
        IRotor NextRotor { get; set; }
        IRotor PreviousRotor { get; set; }
        int RotorState { get; set; }
        public int[] Indices { get; set; }
        int GetEncryptedIndex(int index);
        int GetEncryptedIndexAndRotate(int index);
        int GetDecryptedIndexAndRotate(int index);
        int RotorIndexOf(int value);
        void LeftRotate(int shift);
        void RightRotate(int shift);
        void Reset();
        void SetRotorPosition(int value);
        void SetRotorPosition(IRotorPosition position);
        IRotorPosition GetCurrentPosition();
    }
}