namespace Ciphers
{
    internal class Transposer
    {
        private string _originalString;
        private List<(int, int)> _transpositions;

        public Transposer(string originalString, List<(int n, int o)> transpositions)
        {
            _originalString = originalString;
            _transpositions = transpositions;
        }

        public string JumbleString()
        {
            char[] jumbledArray = _originalString.ToCharArray();

            foreach (var (n, o) in _transpositions)
            {
                // Validity check
                if (n >= 0 && n < _originalString.Length && o >= 0 && o < _originalString.Length)
                {
                    // Swapping characters at positions n and o
                    char temp = jumbledArray[n];
                    jumbledArray[n] = jumbledArray[o];
                    jumbledArray[o] = temp;
                }
            }

            return new string(jumbledArray);
        }
    }
}