using System;
using System.Text;
using System.Text.RegularExpressions;

namespace RunescapeNavigator.Core.Extensions
{
    public static class StringHelpers
    {
        public static string PadRight(string inputString, int length)
        {
            if (inputString.Length >= length)
            {
                return inputString;
            }
            StringBuilder sb = new StringBuilder(inputString);
            while (sb.Length < length)
            {
                sb.Append(" ");
            }

            return sb.ToString();
        }

        public static string CleanString(string inputString)
        {
            // Remove leftover HTML
            string cleanerString = Regex.Replace(inputString, "<.*?>", String.Empty);
            // Remove stray newlines
            cleanerString = cleanerString.Replace("\n", "");
            return cleanerString;
        }
    }
}