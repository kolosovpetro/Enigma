using Enigma.Interfaces;

namespace Enigma.Implementations
{
    public class EncryptedMessage : IEncryptedMessage
    {
        public string Message { get; }
        public int RotorsPosition { get; }

        public EncryptedMessage(string message, int rotorsPosition)
        {
            Message = message;
            RotorsPosition = rotorsPosition;
        }

        public EncryptedMessage()
        {
        }
    }
}