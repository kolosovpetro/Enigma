using System;
using Enigma.Implementations;
using Enigma.Interfaces;

namespace Enigma.UI
{
    public static class Program
    {
        public static void Main()
        {
            var rotor = new Rotor();
            IEnigma enigma = new Implementations.Enigma(rotor);
            var encrypt = enigma.EncryptMessage("ENIGMA");
            Console.WriteLine(encrypt.Message);
            var decrypt = enigma.DecryptMessage(encrypt);
            Console.WriteLine(decrypt);
        }
    }
}