using System;
using System.Globalization;
using System.IO;

namespace CodeAnalysis
{
    public class Methods
    {
        // Not flagged in .net core
        public static void CA1004<T>()
        {
            Console.WriteLine(typeof(T));
        }

        public static void CA1031()
        {
            try
            {
                int.Parse(null);
            }
            catch (Exception)
            {
            }
        }

        // Not flagged in .net core
        public static void CA1062(object input)
        {
            Console.WriteLine(input.GetHashCode());
        }

        // Not flagged in .net core
        public static void CA1303()
        {
            Console.WriteLine("not localized");
        }

        public static string CA1304(string input)
        {
            return input.ToLower();
        }

        // Not flagged in .net core
        public static string CA1305()
        {
            return $"{Guid.NewGuid()} not formatted";
        }

        public static string CA1308(string input)
        {
            if (input == null)
                return null;
            return input.ToLowerInvariant() + input.ToUpperInvariant();
        }

        public static void CA1707_()
        {
        }

        // Not flagged in .net core
        public static void CA1801(object unused)
        {
        }

        private void CA1811()
        {
        }

        // Not flagged in .net core
        public string CA1822(string input)
        {
            return input + input;
        }

        // Not flagged in .net core
        public static void CA2000()
        {
            var stream = new StreamReader(string.Empty);
            int.Parse(null, CultureInfo.InvariantCulture);
            stream.Dispose();
        }
    }
}