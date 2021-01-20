using System;
using Enigma.Implementations;

namespace Enigma.UI
{
    public static class Program
    {
        public static void Main()
        {
            var rotorSet = new RotorSet(new[] {3, 4, 5});
            var enigma = new Implementations.Enigma(rotorSet);
            
            var encrypt = enigma.EncryptMessage("ENIGMA WAS USED IN SECOND WORLD WAR");
            Console.WriteLine(encrypt.Message);    // POFNTDWAKUGUFJGVKBTZVTKLFHBRGUQDLSY
            
            var decrypt = enigma.DecryptMessage(encrypt);
            Console.WriteLine(decrypt);            // ENIGMA WAS USED IN SECOND WORLD WAR
        }
    }
}