using System;
using System.Linq;
using Enigma.Interfaces;
using Enigma.Services;

namespace Enigma.Implementations
{
    public class Rotor : IRotor
    {
        private const int MaxShift = 26;
        private int _totalRotations;
        public int[] Indices { get; set; } = Helper.Indices.ToArray();
        public int RotorPosition { get; set; }

        public Rotor(int rotorsNumber)
        {
        }

        public Rotor()
        {
        }

        public int GetEncryptedIndex(int index)
        {
            return Indices[index];
        }

        public int GetEncryptedIndexAndRotate(int index)
        {
            var currentIndex = GetEncryptedIndex(index);
            RightRotate(1);
            return currentIndex;
        }

        public int GetDecryptedIndexAndRotate(int index)
        {
            LeftRotate(1);
            var currentIndex = RotorIndexOf(index);
            return currentIndex;
        }

        public int RotorIndexOf(int value)
        {
            return Array.IndexOf(Indices, value);
        }

        #region Rotations

        public void LeftRotate(int shift)
        {
            var currentShift = shift;

            if (shift > MaxShift)
            {
                currentShift %= MaxShift;
            }

            var left = Indices.Skip(currentShift);
            var right = Indices.Take(currentShift);
            RotorPosition -= shift;
            Indices = left.Concat(right).ToArray();
        }

        public void RightRotate(int shift)
        {
            var currentShift = shift;

            if (currentShift > MaxShift)
            {
                currentShift %= MaxShift;
            }

            var left = Indices.Take(Indices.Length - currentShift);
            var right = Indices.Skip(Indices.Length - currentShift);
            RotorPosition += shift;
            Indices = right.Concat(left).ToArray();
        }

        #endregion

        public void Reset()
        {
            RotorPosition = 0;
            Indices = Helper.Indices.ToArray();
        }

        public void SetRotorPosition(int value)
        {
            if (value > 0)
                RightRotate(value);

            if (value < 0)
                LeftRotate(-value);
        }
    }
}