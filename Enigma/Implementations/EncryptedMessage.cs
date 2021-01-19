using Enigma.Interfaces;

namespace Enigma.Implementations
{
    public class EncryptedMessage : IEncryptedMessage
    {
        public string Message { get; }
        public int RotorsPosition { get; }
        public int[] RotorPositions { get; set; }

        public EncryptedMessage(string message, int rotorsPosition)
        {
            Message = message;
            RotorsPosition = rotorsPosition;
        }

        public EncryptedMessage(string message, int[] rotorPositions)
        {
            Message = message;
            RotorPositions = rotorPositions;
        }
    }
}