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

        /// <summary>
        /// Checks whether a string exists as a substring within a string while being case insensitive
        /// </summary>
        /// <param name="source"></param>
        /// <param name="toCheck"></param>
        /// <returns></returns>
        public static bool ContainsInsensitive(this string source, string toCheck)
        {
            if (string.IsNullOrEmpty(toCheck) || string.IsNullOrEmpty(source))
                return true;

            return source.IndexOf(toCheck, StringComparison.CurrentCultureIgnoreCase) >= 0;
        }
    }
}