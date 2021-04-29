using System.Collections.Generic;

namespace Hill_Cipher
{
    class Cipher
    {
        private static IDictionary<char, int> Table = new Dictionary<char, int>() {
            {'A', 0} , {'B', 1} , {'C',2 } , {'D' ,3},
            {'E',4 } , {'F',5 } , {'G', 6} , {'H' ,7},
            {'I',8 } , {'J', 9} , {'K', 10} , {'L' ,11},
            {'M',12 } , {'N', 13} , {'O',14 } , {'P' ,15},
            {'Q',16 } , {'R',17 } , {'S', 18} , {'T' ,19},
            {'U',20 } , {'V',21 } , {'W',22 } , {'X' ,23},
            {'Y',24 } , {'Z',25 }
        };

        public static int GetAlphabetValue(char Alphabet)
        {
            foreach (var keyValue in Table)
            {
                if (keyValue.Key == Alphabet)
                {
                    return keyValue.Value;
                }
            }
            return -1; // when there is an error
        }
        public static char GetAlphabetKey(int Value)
        {
            foreach (var keyValue in Table)
            {
                if (keyValue.Value == Value)
                {
                    return keyValue.Key;
                }
            }
            return ' '; // when there is an error
        }
        public static int MultiplicativeInverse(int a)
        {
            for (int x = 1; x < 27; x++)
            {
                if ((a * x) % 26 == 1)
                    return x;
            }
            return a;
        }
    }
}
