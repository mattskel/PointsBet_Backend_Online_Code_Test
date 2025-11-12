using System;
using System.Linq;

namespace PointsBet_Backend_Online_Code_Test
{

    /*
    Improve a block of code as you see fit in C#.
    You may make any improvements you see fit, for example:
      - Cleaning up code
      - Removing redundancy
      - Refactoring / simplifying
      - Fixing typos
      - Any other light-weight optimisation
    */
    public class StringFormatter
    {

        /// <summary>
		/// Converts an array of strings into a comma-separated list.
		/// If <paramref name="quote"/> is provided, each item is wrapped with it.
		/// This method does not escape inner characters (not CSV/SQL aware).
		/// </summary>
		/// <param name="items">Array of strings to format.</param>
		/// <param name="quote">Optional quote/delimiter to surround each item (e.g. ', ").</param>
		/// <returns>A comma-separated string. Returns an empty string for an empty array.</returns>
		public static string ToCommaSeparatedList(string[] items, string? quote)
		{
			if (items is null)
				throw new ArgumentNullException(nameof(items));

			if (items.Length == 0)
				return string.Empty;

			quote ??= string.Empty;

			return string.Join(", ", items.Select(item => $"{quote}{item ?? string.Empty}{quote}"));
		}
    }
}
