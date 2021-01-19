using System.Collections.Generic;
using System.Linq;
using Enigma.Interfaces;

namespace Enigma.Implementations
{
    public class RotorSet : IRotorSet
    {
        public List<IRotor> Rotors { get; }

        private int[] _positions;

        public RotorSet(int rotorsNumber)
        {
            Rotors = new List<IRotor>(Enumerable.Range(1, rotorsNumber)
                .Select(x => new Rotor()));
        }

        public RotorSet(int[] positions)
        {
            _positions = positions;
            Rotors = new List<IRotor>(positions.Select(x => new Rotor(x)));
        }

        public int[] GetPositions()
        {
            throw new System.NotImplementedException();
        }

        public void SetPositions(int[] positions)
        {
            throw new System.NotImplementedException();
        }

        public int GetEncryptedIndexAndRotate(int index)
        {
            throw new System.NotImplementedException();
        }

        public int GetDecryptedIndexAndRotate(int index)
        {
            throw new System.NotImplementedException();
        }

        public void RightRotate(int shift)
        {
            throw new System.NotImplementedException();
        }

        public void LeftRotate(int shift)
        {
            throw new System.NotImplementedException();
        }
    }
}