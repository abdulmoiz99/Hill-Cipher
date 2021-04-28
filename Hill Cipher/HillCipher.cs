using System;

namespace Hill_Cipher
{
    class HillCipher
    {
        public static void Decrypt(string message, int[,] key)
        {
            //Check Determinent

            int det = (key[0, 0] * key[1, 1]) - (key[0, 1] * key[1, 0]);
            if (det == 0)
            {
                Console.WriteLine("Decryption is not possible!");
            }
            det = Cipher.MultiplicativeInverse(det);

            // Take adjoint
            //Change position
            int temp = key[0, 0];
            key[0, 0] = key[1, 1];
            key[1, 1] = temp;
            //change sign
            key[0, 1] = key[0, 1] * -1;
            key[1, 0] = key[1, 0] * -1;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    key[i, j] = key[i, j] / det;

                    if (key[i, j] < 0)
                    {
                        key[i, j] = getPositiveValue(key[i, j]);
                    }
                }
            }

            //Decrytion 
            string plainText = "";
            if (message.Length % 2 != 0) message += "X";

            for (int i = 0; i < message.Length; i = i + 2)
            {
                int a1, a2; // for 2x1 matrix

                a1 = Cipher.GetAlphabetValue(message[i]);
                a2 = Cipher.GetAlphabetValue(message[i + 1]);

                int c1 = (key[0, 0] * a1 + key[0, 1] * a2) % 26;
                int c2 = (key[1, 0] * a1 + key[1, 1] * a2) % 26;

                plainText += Cipher.GetAlphabetKey(c1);
                plainText += Cipher.GetAlphabetKey(c2);
            }
            Console.WriteLine(plainText);
        }
        public static void Encrypt(string message, int[,] key)
        {
            string CipherText = "";
            if (message.Length % 2 != 0) message += "X";

            for (int i = 0; i < message.Length; i = i + 2)
            {
                int a1, a2; // for 2x1 matrix

                a1 = Cipher.GetAlphabetValue(message[i]);
                a2 = Cipher.GetAlphabetValue(message[i + 1]);

                int c1 = (key[0, 0] * a1 + key[0, 1] * a2) % 26;
                int c2 = (key[1, 0] * a1 + key[1, 1] * a2) % 26;

                CipherText += Cipher.GetAlphabetKey(c1);
                CipherText += Cipher.GetAlphabetKey(c2);



            }
            Console.WriteLine("Encrypted Text: " + CipherText);
        }
        public static int getPositiveValue(int value)
        {
            value = value + 26;
            if (value < 0)
            {
                value = getPositiveValue(value);
            }
            return value;
        }
    }
}