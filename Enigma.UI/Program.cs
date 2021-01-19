using System;
using Enigma.Implementations;
using Enigma.Interfaces;

namespace Enigma.UI
{
    public static class Program
    {
        public static void Main()
        {
            var rotorSet = new RotorSet(new[] {3, 4, 5});
            IEnigma enigma = new Implementations.Enigma(rotorSet);
            var encrypt = enigma.EncryptMessage("ENIGMA");
            Console.WriteLine(encrypt.Message);
            var decrypt = enigma.DecryptMessage(encrypt);
            Console.WriteLine(decrypt);
        }
    }
}