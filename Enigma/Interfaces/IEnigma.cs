namespace Enigma.Interfaces
{
    public interface IEnigma
    {
        IEncryptedMessage EncryptMessage(string message);
        string DecryptMessage(IEncryptedMessage message);
        void AddRotor(IRotor rotor);
    }
}