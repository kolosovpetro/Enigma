# Enigma machine

Simulation of the enigma machine written in C#. Currently works only for single rotor case. And it is incredible work to do more. 

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

