using System.Collections.Generic;

namespace Enigma.Interfaces
{
    public interface ILightBar
    {
        List<string> Keys { get; }
        string CurrentKey { get; }
    }
}