using System.Collections.Generic;
using Enigma.Interfaces;

namespace Enigma.Implementations
{
    public class Enigma : IEnigma
    {
        private static List<string> Alphabet { get; } = new List<string>
        {
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", 
            "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
        };

        public string DecryptMessage(IEncryptedMessage message)
        {
            throw new System.NotImplementedException();
        }

        public IEncryptedMessage EncryptMessage(string message)
        {
            throw new System.NotImplementedException();
        }

        public void AddRotor(IRotor rotor)
        {
            throw new System.NotImplementedException();
        }
    }
}