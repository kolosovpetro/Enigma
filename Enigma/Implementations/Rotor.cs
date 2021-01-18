using System;
using System.Linq;
using Enigma.Interfaces;

namespace Enigma.Implementations
{
    public class Rotor : IRotor
    {
        private const int MaxShift = 26;
        private int _totalRotations;

        private int[] _indices =
        {
            20, 25, 8, 18, 15, 24, 1, 21, 12, 7, 23, 19, 11, 14, 2, 3,
            0, 10, 6, 4, 16, 9, 13, 22, 5, 17
        };

        public IRotor NextRotor { get; set; }

        public int RotorState { get; set; }

        public Rotor(int rotorState, int rotorsNumber)
        {
            IRotor currentRotor = this;

            for (var i = 0; i < rotorsNumber - 1; i++)
            {
                currentRotor.NextRotor = new Rotor();
                currentRotor = currentRotor.NextRotor;
            }

            if (rotorState > 0)
                RightRotate(rotorState);

            if (rotorState < 0)
                LeftRotate(-rotorState);
        }

        public Rotor()
        {
        }

        public int GetEncryptedIndex(int index)
        {
            return _indices[index];
        }

        public int GetEncryptedIndexAndRotate(int index)
        {
            var currentIndex = GetEncryptedIndex(index);
            var next = NextRotor;

            while (next != null)
            {
                currentIndex = next.GetEncryptedIndex(currentIndex);
                next = next.NextRotor;
            }

            RightRotate();
            return currentIndex;
        }

        public int GetDecryptedIndexAndRotate(int index)
        {
            LeftRotate();
            return Array.IndexOf(_indices, index);
        }

        public int RotorIndexOf(int value)
        {
            return Array.IndexOf(_indices, value);
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

            var left = _indices.Skip(currentShift);
            var right = _indices.Take(currentShift);
            RotorState -= shift;

            if (NextRotor != null && RotorState / MaxShift < _totalRotations)
            {
                var tempTotalRotations = _totalRotations;
                _totalRotations = RotorState / MaxShift;

                for (var i = _totalRotations; i < tempTotalRotations; i++)
                {
                    NextRotor.LeftRotate();
                }
            }

            _indices = left.Concat(right).ToArray();
        }

        public void RightRotate()
        {
            RightRotate(1);
        }

        public void RightRotate(int shift)
        {
            var currentShift = shift;

            if (currentShift > MaxShift)
            {
                currentShift %= MaxShift;
            }

            var left = _indices.Take(_indices.Length - currentShift);
            var right = _indices.Skip(_indices.Length - currentShift);
            RotorState += shift;

            if (NextRotor != null && RotorState / MaxShift > _totalRotations)
            {
                var tempTotalRotations = _totalRotations;
                _totalRotations = RotorState / MaxShift;

                for (var i = tempTotalRotations; i < _totalRotations; i++)
                {
                    NextRotor.RightRotate();
                }
            }

            _indices = right.Concat(left).ToArray();
        }

        public void Reset()
        {
            IRotor rotor = this;
            while (rotor != null)
            {
                rotor.RotorState = 0;
                rotor = rotor.NextRotor;
            }
        }
    }
}