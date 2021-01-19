using System.Collections.Generic;

namespace Enigma.Interfaces
{
    public interface IRotorSet
    {
        List<IRotor> Rotors { get; }
        int[] GetPositions();
        void SetPositions(int[] positions);
        int GetEncryptedIndexAndRotate(int index);
        int GetDecryptedIndexAndRotate(int index);
        void RightRotate(int shift);
        void LeftRotate(int shift);
    }
}