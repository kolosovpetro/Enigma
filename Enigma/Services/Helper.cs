using System.Collections.Generic;

namespace Enigma.Services
{
    public static class Helper
    {
        public static readonly IEnumerable<int> Indices = new []
        {
            20, 25, 8, 18, 15, 24, 1, 21, 12, 7, 23, 19, 11, 14, 2, 3,
            0, 10, 6, 4, 16, 9, 13, 22, 5, 17, 26
        };
    }
}