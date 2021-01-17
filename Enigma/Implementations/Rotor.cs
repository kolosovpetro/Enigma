using System.Linq;
using Enigma.Interfaces;

namespace Enigma.Implementations
{
    public class Rotor : IRotor
    {
        private const int MaxShift = 26;
        
        private int[] _indices =
        {
            20, 25, 8, 18, 15, 24, 1, 21, 12, 7, 23, 19, 11, 14, 2, 3,
            0, 10, 6, 4, 16, 9, 13, 22, 5, 17
        };

        public IRotor NextRotor { get; set; }

        public int RotorState { get; private set; }

        public int GetEncryptedIndex(int index)
        {
            var currentIndex = _indices[index];
            LeftRotate();
            return currentIndex;
        }

        public void LeftRotate()
        {
            LeftRotate(1);
        }

        public void LeftRotate(int shift)
        {
            var currentShift = shift;
            
            if (shift > MaxShift)
            {
                currentShift %= MaxShift;
            }
            
            var skip = _indices.Skip(currentShift);
            var take = _indices.Take(currentShift);
            _indices = skip.Concat(take).ToArray();
            RotorState += currentShift;
        }

        public void RightRotate()
        {
            LeftRotate(1);
        }

        public void RightRotate(int shift)
        {
            var currentShift = shift;
            var take = _indices.Take(currentShift);
            var skip = _indices.Skip(currentShift);
            _indices = take.Concat(skip).ToArray();
        }
    }
}