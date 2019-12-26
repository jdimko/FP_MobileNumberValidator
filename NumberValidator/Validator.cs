namespace NumberValidator
{
    public static class Validator
    {
        public static bool Run(string input)
        {
            if (Constants.ValidLengths.Contains(input.Length))
            {
                if (Constants.validPrefixes.Contains(input.Substring(0, 6)) || Constants.validPrefixes.Contains(input.Substring(0, 3)))
                {
                    if (double.TryParse(input, out _))
                        return true;
                }
            }

            return false;
        }
    }
}
