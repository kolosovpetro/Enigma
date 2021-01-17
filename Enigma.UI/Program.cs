using System;
using System.Linq;

namespace Enigma.UI
{
    public static class Program
    {
        public static void Main()
        {
            var list = Enumerable.Range(0, 26)
                .OrderBy(x => new Random().Next())
                .ToList();

            list.ForEach(x => Console.Write(x + ", "));
        }
    }
}