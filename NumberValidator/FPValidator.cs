using System;
using System.Linq;

namespace NumberValidator
{
    public static class FPValidator
    {
        private static readonly Func<string, bool> HasCorrectLength = 
            x => Constants.ValidLengths.Contains(x.Length);
        private static readonly Func<string, bool> ContainsValidPrefix = 
            x => Constants.validPrefixes.Contains(x.Substring(0, 6)) || Constants.validPrefixes.Contains(x.Substring(0, 3));
        private static readonly Func<string, bool> IsNumeric = 
            x => double.TryParse(x, out _);
        
        public static bool Validate(this string @this, params Func<string, bool>[] predicates) => predicates.All(x => x(@this));

        public static bool Run(string input)
        {
            return input.Validate(
                HasCorrectLength,
                ContainsValidPrefix,
                IsNumeric
                );
        }
    }
}
