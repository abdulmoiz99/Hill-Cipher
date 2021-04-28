using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hill_Cipher
{
    class Program
    {
        public static void Main(String[] args)
        {
            int[,] key = { { 11, 8 },
                           { 3, 7 } };

            string message = "ZLBT";

            HillCipher.Decrypt(message, key);


            //Console.WriteLine("Hill Cipher");
            //int[,] key = { { 18, 9 },
            //               { 27, 36 } };

            //string message = "EITHERYOUVALUETHETHINGSORYOULOSTVALUE";

            //Console.WriteLine("Plain Text: "+ message);
            //HillCipher.Encrypt(message, key);
            Console.ReadKey();
        }
    }
}