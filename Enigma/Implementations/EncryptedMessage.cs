using Enigma.Interfaces;

namespace Enigma.Implementations
{
    public class EncryptedMessage : IEncryptedMessage
    {
        public string Message { get; }
        public int[] RotorPositions { get; }

        public EncryptedMessage(string message, int[] rotorPositions)
        {
            Message = message;
            RotorPositions = rotorPositions;
        }
    }
}