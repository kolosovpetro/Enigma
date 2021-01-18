namespace Enigma.Interfaces
{
    public interface IRotor
    {
        /// <summary>
        /// Reference to a next rotor in the enigma.
        /// </summary>
        IRotor NextRotor { get; set; }
        
        /// <summary>
        /// Shows how many times rotor was rotated to the right side
        /// </summary>
        int RotorState { get; }

        /// <summary>
        /// Returns encrypted index without rotation of the rotor.
        /// </summary>
        int GetEncryptedIndex(int index);
        
        /// <summary>
        /// Returns an encrypted index and rotates rotor.
        /// Same letter will give different indices.
        /// </summary>
        int GetEncryptedIndexAndRotate(int index);
        
        /// <summary>
        /// Rotates rotor to the right side by 1
        /// </summary>
        void LeftRotate();
        
        /// <summary>
        /// Rotates rotor to the right side by value of shift variable
        /// </summary>
        void LeftRotate(int shift);
        
        /// <summary>
        /// Rotates rotor to the left side by 1
        /// </summary>
        void RightRotate();
        
        /// <summary>
        /// Rotates rotor to the left side by shift value.
        /// </summary>
        void RightRotate(int shift);
    }
}