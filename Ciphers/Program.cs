using System.Text.RegularExpressions;

namespace Ciphers
{
    internal class Program
    {
        static void Main()
        {
            string input = "t h isi sames SAGE";
            string result = StripAndLowerCase(input);
            Console.WriteLine(result);
            var transpositions = new List<(int n, int o)>();
            transpositions.Add((1,3));
            var transposer = new Transposer(result, transpositions);
            Console.WriteLine(transposer.JumbleString());
        }

        static string StripAndLowerCase(string input)
        {
            // Regular expression to remove non-alphabetic characters
            string stripped = Regex.Replace(input, "[^a-zA-Z]", "");

            string lowerCase = stripped.ToLower();

            return lowerCase;
        }
    }
}