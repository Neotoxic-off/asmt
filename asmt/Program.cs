using System;
using System.Collections.Generic;

namespace ASMT
{
    class Program
    {
        private static Dictionary<string, Func<string, string>> converters = new Dictionary<string, Func<string, string>>()
        {
            { "Hex", Bases.Hexadecimal },
            { "Dec", Bases.Decimal },
            { "Oct", Bases.Octal },
            { "Bin", Bases.Binary }
        };

        static void Main(string[] args)
        {
            string? result = null;

            if (args.Length == 1)
            {
                foreach (KeyValuePair<string, Func<string, string>> converter in converters)
                {
                    result = converter.Value(args[0]);
                    Logger.Information($"{converter.Key}: {result}");
                }
            }
        }
    }
}
