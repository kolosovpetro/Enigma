using System.Collections.Generic;

namespace Enigma.Interfaces
{
    public interface IEnigma
    {
        IRotorSet RotorSet { get; }
        IEncryptedMessage EncryptMessage(string message);
        string DecryptMessage(IEncryptedMessage message);
    }
}