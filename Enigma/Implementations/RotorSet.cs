using System;
using System.Collections.Generic;
using System.Linq;
using Enigma.Interfaces;

namespace Enigma.Implementations
{
    public class RotorSet : IRotorSet
    {
        public List<IRotor> Rotors { get; private set; }

        public RotorSet(int rotorsNumber)
        {
            Rotors = new List<IRotor>(Enumerable.Range(1, rotorsNumber)
                .Select(x => new Rotor()));
        }

        public RotorSet(int[] positions)
        {
            Rotors = new List<IRotor>(positions.Select(x => new Rotor(x)));
        }

        public int[] GetPositions()
        {
            return Rotors.Select(x => x.Position).ToArray();
        }

        public void SetPositions(int[] positions)
        {
            if (positions.Length != Rotors.Count)
                throw new InvalidOperationException("Rotor count should be equal to pos. count.");

            Rotors = new List<IRotor>(positions.Select(x => new Rotor(x)));
        }

        public int GetEncryptedIndexAndRotate(int index)
        {
            var first = Rotors.First();
            var encryptedIndex = first.GetEncryptedIndex(index);

            for (var i = 1; i < Rotors.Count; i++)
            {
                encryptedIndex = Rotors[i].GetEncryptedIndex(encryptedIndex);
            }

            first.RightRotate(1);
            return encryptedIndex;
        }

        public int GetDecryptedIndexAndRotate(int index)
        {
            var first = Rotors.First();
            first.LeftRotate(1);

            var decryptedIndex = Rotors.Last().GetDecryptedIndex(index);

            for (var i = Rotors.Count - 2; i >= 0; i--)
            {
                decryptedIndex = Rotors[i].GetDecryptedIndex(decryptedIndex);
            }

            return decryptedIndex;
        }

        public void RightRotate(int shift)
        {
            var rotor = Rotors.First();
            rotor.RightRotate(shift);

            for (var i = 1; i < Rotors.Count; i++)
            {
                var difference = Rotors[i - 1].TotalRotationsCount - Rotors[i].Position;

                if (difference > 0)
                {
                    Rotors[i].RightRotate(difference);
                }
            }
        }

        public void LeftRotate(int shift)
        {
            var rotor = Rotors.First();
            rotor.LeftRotate(shift);

            for (var i = 1; i < Rotors.Count; i++)
            {
                var difference = Rotors[i - 1].TotalRotationsCount - Rotors[i].Position;

                if (difference < 0)
                {
                    Rotors[i].LeftRotate(-difference);
                }
            }
        }
    }
}