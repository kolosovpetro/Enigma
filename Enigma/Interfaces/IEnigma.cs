namespace Enigma.Interfaces
{
    public interface IEnigma
    {
        string EncryptMessage(string message);
        string DecryptMessage(string message);
        void AddRotor(IRotor rotor);
    }
}