using System;
using System.Text;

namespace XORCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string plainText = Input("Enter plaintext: ");
            char key = char.Parse(Input("Enter key: "));
            XORCipherStart(plainText, key);
        }

        private static void XORCipherStart(string plainText, char key)
        {
            string cipherText = Encrypt(plainText, key);
            Decrypt(cipherText, key);
        }

        private static void Decrypt(string cipherText, char key)
        {
            string decryptedText = XORDecryption(cipherText, key);
            Console.WriteLine($"Decrypted text:\n{decryptedText}");
        }

        private static string Encrypt(string plainText, char key)
        {
            string cipherText = XOREncryption(plainText, key);
            Console.WriteLine($"Encrypted text:\n{cipherText}");
            return cipherText;
        }

        private static string XORDecryption(string cipherText, char key)
        {
            return XOREncryption(cipherText, key);
        }

        private static string XOREncryption(string plaintext, char key)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char character in plaintext)
                sb.Append((char)(character ^ key));
            return sb.ToString();
        }

        private static string Input(string displayMessage)
        {
            Console.Write(displayMessage);
            return Console.ReadLine();
        }
    }
}
