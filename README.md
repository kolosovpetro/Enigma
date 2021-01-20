# Enigma machine

When I was a child I remember a how I was impressed by movie Enigma(2001). That long time ago it was literally magic for me to understand how enigma machine works.

Now I can write my own enigma. That's amazing!

## Code snippet

```cs
var rotorSet = new RotorSet(new[] {3, 4, 5});
var enigma = new Implementations.Enigma(rotorSet);
            
var encrypt = enigma.EncryptMessage("ENIGMA WAS USED IN SECOND WORLD WAR");
Console.WriteLine(encrypt.Message);    // POFNTDWAKUGUFJGVKBTZVTKLFHBRGUQDLSY
            
var decrypt = enigma.DecryptMessage(encrypt);
Console.WriteLine(decrypt);            // ENIGMA WAS USED IN SECOND WORLD WAR
```

## Me near enigma monument

![DbSchema](me.jpg?raw=true)

## Encryption pseudocode

Input: Char T

Output: Encoded Char H

- K = Alphabet.IndexOf(T);
- Z = R[K]: value of rotor R at index K
- Rotate rotor R to right by 1, position P = P + 1
- Return H = Alphabet element at index Z

## Decryption pesudocode

Input: Encoded Char H

Output: Decoded Char T

- Z = Alphabet index of H;
- Rotate rotor R to left by 1, eg P = P - 1
- K = Rotor index of Z
- Return Alphabet[K]

