using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enigma.Interfaces;

namespace Enigma.Implementations
{
    public class Enigma : IEnigma
    {
        private static List<char> Alphabet { get; } = new List<char>
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
            'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };

        private static readonly StringBuilder Builder = new StringBuilder();

        private readonly IRotor _rotor;

        public Enigma(IRotor rotor)
        {
            _rotor = rotor;
        }

        public string DecryptMessage(IEncryptedMessage message)
        {
            var stack = new Stack<char>();
            _rotor.Reset();
            _rotor.SetRotorPosition(message.RotorsPosition);
            var text = message.Message.Reverse();
            Builder.Clear();
            
            foreach (var letter in text)
            {
                var encryptedIndex = Alphabet.IndexOf(letter);
                _rotor.LeftRotate(1);
                var decryptedIndex = _rotor.RotorIndexOf(encryptedIndex);
                stack.Push(Alphabet[decryptedIndex]);
            }

            while (stack.Count > 0) 
                Builder.Append(stack.Pop());

            return Builder.ToString();
        }

        public IEncryptedMessage EncryptMessage(string message)
        {
            Builder.Clear();
            foreach (var letter in message)
            {
                var index = Alphabet.IndexOf(letter);
                var encryptedIndex = _rotor.GetEncryptedIndexAndRotate(index);
                Builder.Append(Alphabet[encryptedIndex]);
            }

            return new EncryptedMessage(Builder.ToString(), _rotor.RotorState);
        }
    }
}