using System;
using System.Linq;
using Enigma.Interfaces;

namespace Enigma.Implementations
{
    public class Rotor : IRotor
    {
        #region PrivateMembers

        private const int MaxShift = 26;
        private int _totalRotations;

        #endregion

        #region PublicProperties

        public int[] Indices { get; set; } = Helper.Indices.ToArray();
        public IRotor NextRotor { get; set; }
        public IRotor PreviousRotor { get; set; }
        public IRotorPosition RotorPosition { get; set; }
        public int RotorState { get; set; }

        #endregion

        #region Constructors

        public Rotor(int rotorState, int rotorsNumber)
        {
            IRotor currentRotor = this;

            for (var i = 0; i < rotorsNumber - 1; i++)
            {
                currentRotor.NextRotor = new Rotor();
                currentRotor = currentRotor.NextRotor;
            }

            SetRotorPosition(rotorState);
        }

        public Rotor(IRotorPosition rotorPosition)
        {
            RotorPosition = rotorPosition;
        }

        public Rotor()
        {
        }

        #endregion

        #region EncryptDecrypt

        public int GetEncryptedIndex(int index)
        {
            return Indices[index];
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

            RightRotate(1);
            return currentIndex;
        }

        public int GetDecryptedIndexAndRotate(int index)
        {
            LeftRotate(1);
            var currentIndex = RotorIndexOf(index);
            var next = NextRotor;

            while (next != null)
            {
                currentIndex = next.RotorIndexOf(currentIndex);
                next = next.NextRotor;
            }

            return currentIndex;
        }

        public int RotorIndexOf(int value)
        {
            return Array.IndexOf(Indices, value);
        }

        #endregion

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
            RotorState -= shift;

            if (NextRotor != null && RotorState / MaxShift < _totalRotations)
            {
                var tempTotalRotations = _totalRotations;
                _totalRotations = RotorState / MaxShift;

                for (var i = _totalRotations; i < tempTotalRotations; i++)
                {
                    NextRotor.LeftRotate(1);
                }
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
            RotorState += shift;

            if (NextRotor != null && RotorState / MaxShift > _totalRotations)
            {
                var tempTotalRotations = _totalRotations;
                _totalRotations = RotorState / MaxShift;

                for (var i = tempTotalRotations; i < _totalRotations; i++)
                {
                    NextRotor.RightRotate(1);
                }
            }

            Indices = right.Concat(left).ToArray();
        }

        #endregion

        public void Reset()
        {
            IRotor rotor = this;
            while (rotor != null)
            {
                rotor.RotorState = 0;
                rotor.Indices = Helper.Indices.ToArray();
                rotor = rotor.NextRotor;
            }
        }

        public void SetRotorPosition(int value)
        {
            if (value > 0)
                RightRotate(value);

            if (value < 0)
                LeftRotate(-value);
        }

        public void SetRotorPosition(IRotorPosition position)
        {
            throw new NotImplementedException();
        }
    }
}