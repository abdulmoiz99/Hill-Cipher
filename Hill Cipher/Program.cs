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



            Console.WriteLine("Hill Cipher");
            //int[,] key = { { 18, 9 },
            //               { 27, 36 } };

            //string message = "EITHERYOUVALUETHETHINGSORYOULOSTVALUE";

            //Console.WriteLine("Plain Text: " + message);
            //HillCipher.Encrypt(message, key);


            int[,] key = { { 7, 8 },
                           { 11, 11 } };

            string message = "APADJTFWLFJ";
            Console.WriteLine("Cipher Text: " + message);
            HillCipher.Decrypt(message, key);

            Console.ReadKey();
        }
    }
}