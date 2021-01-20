using System;
using System.Linq;
using Enigma.Interfaces;
using Enigma.Services;

namespace Enigma.Implementations
{
    public class Rotor : IRotor
    {
        private const int MaxShift = 27;
        public int[] Indices { get; set; } = Helper.Indices.ToArray();
        public int Position { get; set; }
        public int TotalRotationsCount { get; set; }

        public Rotor(int rotorPosition)
        {
            SetRotorPosition(rotorPosition);
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
            var currentIndex = GetDecryptedIndex(index);
            return currentIndex;
        }

        public int GetDecryptedIndex(int value)
        {
            return Array.IndexOf(Indices, value);
        }

        public void LeftRotate(int shift)
        {
            var currentShift = shift;

            if (shift > MaxShift)
            {
                currentShift %= MaxShift;
            }

            var left = Indices.Skip(currentShift);
            var right = Indices.Take(currentShift);
            Position -= shift;

            if (Position / 26 < TotalRotationsCount)
            {
                TotalRotationsCount = Position / MaxShift;
            }
            
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
            Position += shift;
            
            if (Position / MaxShift > TotalRotationsCount)
            {
                TotalRotationsCount = Position / MaxShift;
            }

            Indices = right.Concat(left).ToArray();
        }

        public void Reset()
        {
            Position = 0;
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