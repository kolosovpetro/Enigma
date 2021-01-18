namespace Enigma.Interfaces
{
    public interface IEncryptedMessage
    {
        string Message { get; }
        int RotorsPosition { get; }
    }
}