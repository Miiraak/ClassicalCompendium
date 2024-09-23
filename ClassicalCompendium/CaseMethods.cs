using System.Globalization;
using System.Linq;

namespace ClassicalCompendium
{
    public class CaseMethods
    {
        /// <summary>
        /// This method converts a string to sentence case.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string SentenceCase(string input)
        {
            string[] words = input.ToLowerInvariant().Split(' ');
            words = words.Select((word, index) => index == 0 ? char.ToUpperInvariant(word[0]) + word.Substring(1) : word).ToArray();
            return string.Join(" ", words); 
        }

        /// <summary>
        /// This method converts a string to title case based on current culture.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string TitleCase(string input)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(input.ToLowerInvariant());
        }

        /// <summary>
        /// This method capitalizes the first letter of each word in a string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string StartCase(string input)
        {
            string[] words = input.ToLowerInvariant().Split(' ');
            words = words.Select(word => char.ToUpperInvariant(word[0]) + word.Substring(1)).ToArray();
            return string.Join(" ", words);
        }

        /// <summary>
        /// This method converts a string to all caps.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string AllCaps(string input)
        {
            return input.ToUpperInvariant();
        }

        /// <summary>
        /// This method converts a string to all lower case.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string AllLower(string input)
        {
            return input.ToLowerInvariant();
        }

        /// <summary>
        /// This method converts a string to camel case.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string DromedaryCase(string input)
        {
            string[] words = input.ToLowerInvariant().Split(' ');
            words = words.Select((word, index) => index == 0 ? word : char.ToUpperInvariant(word[0]) + word.Substring(1)).ToArray();
            return string.Join("", words);
        }

        /// <summary>
        /// This method converts a string to snake case.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        // hello_little_world
        public static string SnakeCase(string input)
        {
            return input.Replace(" ", "_").ToLowerInvariant();
        }

        /// <summary>
        /// This method converts a string to kebab case.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string KebabCase(string input)
        {
            return input.Replace(" ", "-").ToLowerInvariant();
        }

        /// <summary>
        /// This method converts a string to pascal case.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string CamelCase(string input)
        {
            string[] words = input.ToLowerInvariant().Split(' ');
            words = words.Select(word => char.ToUpperInvariant(word[0]) + word.Substring(1)).ToArray();
            return string.Join("", words);
        }

        /// <summary>
        /// This method converts a string to studly caps. The method used is fully randomized.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string StudlyCaps(string input)
        {
            char[] chars = input.ToLowerInvariant().ToCharArray();

            chars = chars.Select(c => RandomMethods.RandomInteger(0, 1) == 0 ? char.ToUpperInvariant(c) : c).ToArray();

            return new string(chars);
        }
    }
}
